Docker-Mono
===========

This project is a simple PoC showing .Net running via Mono in a [Docker](https://www.docker.com/) container, completely isolated.

To try it out, simply install Docker (if you don't already have it!) 
	
	curl -s https://get.docker.io/ubuntu/ | sudo sh

And then

	git clone https://github.com/andmos/Docker-Mono.git 
	chmod +x DeployHelloWorld
	./DeployHelloWorld
	
Or use the `vagrantfile`:

	vagrant up
	vagrant ssh
	cd /vagrant/
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

But what about webapps? 

The [OWIN Katana project](http://katanaproject.codeplex.com/) promises to take away the need for IIS.
Lets try that in Docker:
		
		git clone https://github.com/andmos/Docker-Mono.git
		./DeployKatanaTest
		Started! Hello from OWA Katana, running isolated in Docker!

Head over to http://localhost and see for yourself.
<br>
Oh, did I mention [SingnalR runs on Katana?](http://www.dotnetcurry.com/showarticle.aspx?ID=915)

Feel free to use the [Dockerfile](https://github.com/andmos/Docker-Mono/blob/master/Docker-mono/Dockerfile) for Mono and do youre own testing and packing! 

This project [stands on the shoulders of giants.](http://friism.com/running-net-apps-on-docker)
