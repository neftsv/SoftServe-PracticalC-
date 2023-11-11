using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

class Worker
{
    public int Id {  get; set; }
    public string Name { get; set; }
    public decimal Salary {  get; set; }
    public Department Department { get; set; }
    public Worker(string name, decimal salary, Department department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string Serialize()
    {
        var workerJson = new
        {
            Full_name = Name,
            Salary,
            Department = new
            {
                Name = Department.Name,
                Id = Department.Id,
                Manager = Department.Manager != null ? new
                {
                    Full_name = Department.Manager.Name,
                    Salary = Department.Manager.Salary
                } : null
            }
        };

        return JsonSerializer.Serialize(workerJson);
    }

    public static Worker Deserialize(string json)
    {
        var workerJson = JsonSerializer.Deserialize<WorkerJson>(json);

        return CreateWorkerFromWorkerJson(workerJson);
    }
    private class WorkerJson
    {
        public string Full_name { get; set; }
        public decimal Salary { get; set; }
        public DepartmentJson Department { get; set; }
    }

    private class DepartmentJson
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public WorkerJson Manager { get; set; }
    }
    private static Worker CreateWorkerFromWorkerJson(WorkerJson workerJson)
    {
        var manager = workerJson.Department?.Manager != null
            ? new Worker(workerJson.Department.Manager.Full_name, workerJson.Department.Manager.Salary, null)
            : null;

        return new Worker(workerJson.Full_name, workerJson.Salary, new Department(workerJson.Department.Name, workerJson.Department.Id, manager));
    }
}
class Department
{
    public string Name { get; set; }
    public int Id {  get; set; }
    public Worker Manager { get; set; }

    public Department(string name, int id, Worker manager)
    {
        Name = name;
        Id = id;
        Manager = manager;
    }
    
}

//class Pr
//{
//    static void Main()
//    {
//        Worker w = new Worker("Anna", 700, new Department("Mechanics", 1, new Worker("Tom", 600, null)));

//        // Serialize
//        string serializedWorker = w.Serialize();
//        Console.WriteLine(serializedWorker);

//        // Deserialize
//        Worker deserializedWorker = Worker.Deserialize(serializedWorker);
//        //Console.WriteLine($"Deserialized Worker: {deserializedWorker.Name}, Salary: {deserializedWorker.Salary}");
//    }
//}

