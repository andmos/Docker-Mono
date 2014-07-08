Docker-Mono
===========

This project is a simple PoC showing .Net running via Mono in a [Docker](https://www.docker.com/) container, completely isolated.

To try it out, simply install Docker (if you don't already have it!) 
	
	curl -s https://get.docker.io/ubuntu/ | sudo sh

And then

	git clone https://github.com/andmos/Docker-Mono.git 
	chmod +x DeployHelloWorld
	./DeployHelloWorld
	
The Dockerfile looks for .exe's `HelloWorldProject/bin/Debug`.


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

