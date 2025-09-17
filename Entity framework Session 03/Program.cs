using Entity_framework_Session_03.Data;
using Entity_framework_Session_03.Models;

namespace Entity_framework_Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using AppDbContext dbContext = new AppDbContext();
            #region a
            /*Insert a new airline named "EgyptAir" with contact person "Ahmed Ali",
           * phone "0123456789" and “0113654789”, and address "Cairo".*/

            //var airline = new Airline() { Name = "EgyptAir", Cont_person = "Ahmed Ali", Address = "Cairo" };
            //airline.airline_Phones.Add(new Airline_Phone() { Airline = airline, Phones = "0123456789" });
            //airline.airline_Phones.Add(new Airline_Phone() { Airline = airline, Phones = "0113654789" });
            //dbContext.Airlines.Add(airline);
            //dbContext.SaveChanges();
            #endregion

            #region b
            /*Add a new aircraft with model "Model01", capacity 180, and airline = "EgyptAir".*/
            //var airline=dbContext.Airlines.FirstOrDefault(a=>a.Name== "EgyptAir");
            //if (airline != null)
            //{
            //    var aircraft = new Aircraft()
            //    {
            //        Model = "Model01",
            //        Capacity = 180,
            //        Crew = new Crew()
            //        {
            //            Maj_pilot = "Ahmed Ali",
            //            Assistant = "Sara Mohamed",
            //            Host1 = "Omar Hassan",
            //            Host2 = "Laila Adel"
            //        },
            //        Airline = airline
            //    };
            //    dbContext.Aircrafts.Add(aircraft);
            //    dbContext.SaveChanges();
            //}

            #endregion

            #region C
            /*Record a new transaction of amount 50000 with description "Tickets" for "EgyptAir"*/
            //var airline = dbContext.Airlines.FirstOrDefault(a => a.Name == "EgyptAir");
            //airline?.Transactions.Add(new Transaction() { Amout = 50000, Description = "Tickets" });
            //dbContext.SaveChanges();
            #endregion

            #region D
            /*Select all employees who work in "EgyptAir".*/
            //var result=dbContext.Employees.Where(e=>e.Airline.Name== "EgyptAir").ToList();
            //foreach (var e in result)
            //{
            //    Console.WriteLine(e);
            //}
            #endregion

            #region e
            /*Show all transactions (id, description, amount) recorded by "EgyptAir".*/
            //var result = dbContext.Transactions.Where(e => e.Airline.Name == "EgyptAir");
            //foreach (var transaction in result)
            //{
            //    Console.WriteLine($"{transaction.TransactionId} - {transaction.Description} - {transaction.Amout}");
            //}
            #endregion

            #region f
            /*Get the total number of employees working in each airline.*/
            //var result = dbContext.Employees.GroupBy(E => E.AL_Id)
            //    .Select(g => new { g.Key, Count=g.Count() });
            //foreach (var e in result)
            //{
            //    Console.WriteLine($"{e.Key} - {e.Count}");
            //}
            #endregion

            #region g
            //Change the capacity of the “Model01”  aircraft to 200.
            //var result = dbContext.Aircrafts.FirstOrDefault(e => e.Model == "Model01");

            //if (result != null)
            //{
            //    result.Capacity = 200;
            //}
            //dbContext.SaveChanges();
            //Console.WriteLine(result?.Model);
            #endregion

            #region H
            // Delete all transactions older than 2020.
            //var result = dbContext.Transactions.Where(e => e.Date.Year < 2020);
            //dbContext.Transactions.RemoveRange(result);
            //dbContext.SaveChanges();
            #endregion

            #region I
            /*Insert a new route from "Cairo" to "Dubai", classification "International", distance 2400 km.*/
            //dbContext.Routes.Add(new Route()
            //{
            //    Destination = "Dubai",
            //    Origin = "Cairo",
            //    Classification = "International"
            //    ,
            //    Distance = 2400

            //});
            //dbContext.SaveChanges();

            #endregion

            #region j
            /*Assign  “Model01”  aircraft to Route From  "Cairo" 
             * to "Dubai". With duration 4 hours, price 3000 LE*/
            //var aircraft = dbContext.Aircrafts.FirstOrDefault(a => a.Model == "Model01");
            //var route = dbContext.Routes.FirstOrDefault(r => r.Origin == "Cairo" && r.Destination == "Dubai");
            //if (aircraft != null && route != null)
            //{
            //    var departure = DateTime.Now;
            //    var arrival = departure.AddHours(4);

            //    var aircraftRoute = new Aircraft_Route
            //    {
            //       route= route,
            //       aircraft= aircraft,
            //        Departure = departure,
            //        Arrival = arrival,
            //        Num_Of_Pass = 180,
            //        Price = 3000
            //    };

            //    dbContext.Aircraft_Routes.Add(aircraftRoute);
            //    dbContext.SaveChanges();
            //}

            #endregion
        }
    }
}
