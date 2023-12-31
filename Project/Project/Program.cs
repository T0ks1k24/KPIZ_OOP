﻿using Project;
using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Text;

namespace Project
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            Person person1 = new Person("Anton", "Mal", new DateTime(2013, 3, 19));
            Person person2 = new Person("Yr", "Hilyd", new DateTime(2000, 2, 12));

            Console.WriteLine($"Рівність: {ReferenceEquals(person1, person2)}");
            Console.WriteLine($"Рівність об'єктів: {person1.Equals(person2)}");
            Console.WriteLine();

            Console.WriteLine($"Хеш-код person1: {person1.GetHashCode()}");
            Console.WriteLine($"Хеш-код person2: {person2.GetHashCode()}");
            Console.WriteLine();

            Student student = new Student
            (
                new Person("Anton", "Mal", new DateTime(2004, 3, 19)),
                Education.Bachelor,
                123,
                new ArrayList() { new Test("Математика", true), new Test("Українська мова", false), new Test("Надійність", true) },
                new ArrayList() { new Exam("Фізика", true, 4), new Exam("ООП", true, 5), new Exam("База Даних", false, 3) }
            );

            Console.WriteLine("Дані про студентів:");
            Console.WriteLine(student);

            Console.WriteLine();

            Student studentCopy = (Student)student.DeepCopy();

            studentCopy.FirstName = "Tania";
            studentCopy.LastName = "Horephga";
            studentCopy.GroupNumber = 400;

            Student studentCopy2 = (Student)student.DeepCopy();

            Console.WriteLine("Копія 1:");
            Console.WriteLine(studentCopy);
            Console.WriteLine("Копія 2:");
            Console.WriteLine(studentCopy2);
            Console.WriteLine("Оригінал:");
            Console.WriteLine(student);
            Console.WriteLine();

            try
            {
                student.GroupNumber = 50;
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Виняток спіймано: {ex.Message}");
                Console.ResetColor();
            }
            Console.WriteLine();

            Console.WriteLine("Тести та іспити:");
            foreach (var testOrExam in student.GetEnumerator())
            {
                Console.WriteLine(testOrExam);
            }
            Console.WriteLine();

            Console.WriteLine("Іспити з оцінкою вище 3:");
            foreach (var exam in student.GetExamsWithGradeGreaterThan(3))
            {
                Console.WriteLine(exam);
            }
            Console.WriteLine();

            Console.WriteLine("Предмети з тестами та іспитах:");
            foreach (var subject in student.GetEnumeratorList())
            {
                Console.WriteLine(subject);
            }
            Console.WriteLine();

            Console.WriteLine("Пройдені тести та іспити:");
            foreach (var testOrExam in student.GetPasssedTestsAndExamsEnumerator())
            {
                Console.WriteLine(testOrExam);
            }
            Console.WriteLine();
        }
    }
}