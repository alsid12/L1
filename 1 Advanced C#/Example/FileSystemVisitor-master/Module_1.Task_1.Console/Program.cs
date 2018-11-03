using System;
using System.Collections.Generic;
using System.IO;

namespace Module_1.Task_1.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();
            
            Predicate<string> uipath = (toinclude) => toinclude.Contains("xaml") && !toinclude.Contains("Main");
            

            FileSystemVisitor fsVisitor;
            try
            {
                fsVisitor = new FileSystemVisitor(path, uipath);
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Invalid directory path.", e);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Invalid argument.", e);
            }
            catch (Exception)
            {
                throw;
            }

            fsVisitor.VisitStarted += (sender, e) => { Console.WriteLine("EVENT VisitStarted"); };
            fsVisitor.VisitFinished += (sender, e) => { Console.WriteLine("EVENT VisitFinished"); };

            fsVisitor.DirectoryFound += (sender, e) => { Console.WriteLine($"EVENT -Dir: {e.Path}"); };
            fsVisitor.FileFound += (sender, e) => { Console.WriteLine($"EVENT File: {e.Path}"); };

            fsVisitor.FilteredDirectoryFound += (sender, e) => { Console.WriteLine($"EVENT -Filtered Dir: {e.Path}"); };
            fsVisitor.FilteredFileFound += (sender, e) => { Console.WriteLine($"EVENT  Filtered File: {e.Path}"); };

            var result = new List<string>();
            try
            {
                foreach (var item in fsVisitor)
                {
                    result.Add(item);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Invalid directory path.", e);
            }
            catch (Exception)
            {
                throw;
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
