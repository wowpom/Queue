using System;
using System.Collections.Generic;


namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue <Person> person = new Queue<Person>();

            person.Enqueue(new Person() { Name = "Polina" });
            person.Enqueue(new Person() { Name = "Evgeny" });
            person.Enqueue(new Person() { Name = "Pavel" });

            Person PerosonFromQueue = person.Peek();
            Console.WriteLine(PerosonFromQueue.Name + "\n");

            foreach(Person p in person)
            {
                Console.WriteLine(p.Name);
            }

        }
    }
}
//Dequeue: извлекает и возвращает первый элемент очереди

//Enqueue: добавляет элемент в конец очереди

//Peek: просто возвращает первый элемент из начала очереди без его удаления
