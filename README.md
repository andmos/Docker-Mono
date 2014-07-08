Docker-Mono
===========

This project is a simple PoC showing .Net running via Mono in a [Docker](https://www.docker.com/) container, completely isolated.


The app that is running is a simple HelloWorld - program in C#: 

    using System;

    namespace HelloWorldProject
    {
	      class MainClass
	      {
		        public static void Main (string[] args)
		        {
			            Console.WriteLine ("Hello World!");
		        }
	      }
    }

