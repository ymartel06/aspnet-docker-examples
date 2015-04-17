# aspnet-docker-examples

### MVC Simple

MVC Simple is just a little MVC Application running inside Docker.

From Ubuntu Command Line:

 * git clone https://github.com/ymartel06/aspnet-docker-examples.git
 * cd aspnet-docker-examples/mvc-simple/
 * sudo docker build -t mvc-simple .
 * sudo docker run -t -d -p 80:5004 mvc-simple 
 

Browse to http://localhost/ and you should use the MVC Welcome page.
To view another one, browse http://localhost/Home/Index.

## Missing Git or Docker?

* sudo apt-get install git
* sudo apt-get install docker.io
