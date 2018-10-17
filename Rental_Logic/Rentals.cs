﻿using System;
using System.Collections.Generic;
using Rental_Data;
using System.Linq;

namespace Rental_Logic
{
    public class Rentals
    {
        public List<Car> Cars = new List<Car>();
        public List<Customer> Customers = new List<Customer>();
        public List<Booking> Bookings = new List<Booking>();
        
   
        public void AddCar(int regNumber, string brand, int year, string model)
        {
            Car newCar = new Car() {
                RegNumber = regNumber,
                Brand = brand,
                Year = year,
                Model = model,
                IsRented = false
            };
            Cars.Add(newCar);
        }
        public void RemoveCar(int regNumber)
        {
            Cars.RemoveAll(b => b.RegNumber == regNumber);
        }
        public void AddCustomer(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            Customer newCustomer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                EmailAddress = emailAddress

            };
            Customers.Add(newCustomer);
        }
        public void RemoveCustomer(string firstName, string lastName, int id)
        {

            Customers.RemoveAll(c => c.FirstName == firstName && c.LastName == lastName && c.Id == id);

        }


        public void AddBooking(Car rentalCar, Customer renter, DateTime startTime, DateTime endTime)

        {
            Booking newBooking = new Booking()
            {
                Id = renter.FullName + renter.Id,
                RentalCar = rentalCar,
                Renter = renter,
                StartTime = startTime,
                EndTime = endTime,
                IsReturned = false

            };
            Bookings.Add(newBooking);

        }

        public void DeleteBooking(string bookingId)
        {
            Bookings.RemoveAll(b => b.Id == bookingId);
        }

    }

 }