
using CarParkProject.Core.Abstract;
using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Data.UnitOfWorks;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using CarParkProject.Domain.ViewModels;
using CarParkProject.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Concreate
{
    public class PaymentService : Service<Ticket>, IPaymentService
    {
        private readonly IPaymentRepository _ticket;
        private readonly IRepository<RateCard> _rateCartRepository;
        public PaymentService(IPaymentRepository repository, IRepository<RateCard> rateCartRepository) :
       base(repository)
        {
            this._ticket = repository;
            this._rateCartRepository = rateCartRepository;
        }

        //When paying ticket before Checkout for calculate parking fees
        public ServiceResult<Ticket> CalculateParkingFees(int id)
        {
            ServiceResult<Ticket> res = new ServiceResult<Ticket>();
           

            try
            {
                Ticket ticketData = _ticket.GetAllAsync().Result.Where(x => x.Id==id).FirstOrDefault();

                if (ticketData is not null)
                {
                    var rateCards = _rateCartRepository.GetAllAsync().Result.Where(x => x.VehicleCategoryId == ticketData.VehicleCategoryId).FirstOrDefault();
                    //Calculate parkingFees hourly-daily period and update ticket
                    var parkingTime = DateTime.Now - ticketData.CheckIn;
                    if(parkingTime.TotalHours<7)
                    {
                        ticketData.ParkingFees = rateCards.DailyPrice * (int)parkingTime.TotalHours;
                    }
                    else
                    {
                        ticketData.ParkingFees = rateCards.DailyPrice * (int)parkingTime.TotalDays;
                        
                    }
               //     ticketData.PayDate = DateTime.Now;
                    _ticket.Update(ticketData);

                }
                res.Ok();
                res.Result = ticketData;
               

            }
            catch (Exception)
            {

                res.Fail();
            }
            return res;
        }

        public ServiceResult<Ticket> CalculateAndPayParkingFees(int id)
        {
            ServiceResult<Ticket> res = new ServiceResult<Ticket>();


            try
            {
                Ticket ticketData = _ticket.GetAllAsync().Result.Where(x => x.Id == id).FirstOrDefault();

                if (ticketData is not null)
                {
                    var rateCards = _rateCartRepository.GetAllAsync().Result.Where(x => x.VehicleCategoryId == ticketData.VehicleCategoryId).FirstOrDefault();
                    //Calculate parkingFees hourly-daily period and update ticket
                    var parkingTime = DateTime.Now - ticketData.CheckIn;
                    if (parkingTime.TotalHours < 7)
                    {
                        ticketData.ParkingFees = rateCards.DailyPrice * (int)parkingTime.TotalHours;
                    }
                    else
                    {
                        ticketData.ParkingFees = rateCards.DailyPrice * (int)parkingTime.TotalDays;

                    }
                    ticketData.PayDate = DateTime.Now;
                    _ticket.Update(ticketData);

                }
                res.Ok();
                res.Result = ticketData;


            }
            catch (Exception)
            {

                res.Fail();
            }
            return res;
        }

        //public List<CustomerVM> GetAllCustomers()
        //{
        //    var customers = _customer.GetAllAsync().Result;
        //    List<CustomerVM> result = new List<CustomerVM>() { };

        //    foreach (var item in customers)
        //    {
        //        result.Add(new CustomerVM()
        //        {
        //            Id = item.Id,
        //            TCNumber = item.TCNumber,
        //            Address = item.Address,
        //            Email = item.Email,
        //            Name = item.Name,
        //            Surname = item.Surname,
        //            PhoneNumber = item.PhoneNumber,
        //        });
        //    }


        //    return result;

        //}


    }
}
