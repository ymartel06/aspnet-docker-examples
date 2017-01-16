# aspnet-docker-examples

### MVC Simple

MVC Simple is just a little MVC Application running inside Docker.

From Ubuntu Command Line:

 * git clone https://github.com/ymartel06/aspnet-docker-examples.git
 * cd aspnet-docker-examples/mvc-simple/
 * sudo docker build -t mvc-simple .
 * sudo docker run -t -d -p 5000:5000 mvc-simple 
 

Browse to http://localhost/ and you should use the MVC Welcome page.

### WEBAPI Simple

WEBAPI Simple is a simple example to how to setup a WEBAPI inside Docker

From Ubuntu Command Line:

 * git clone https://github.com/ymartel06/aspnet-docker-examples.git
 * cd aspnet-docker-examples/webapi-simple/
 * sudo docker build -t webapi-simple .
 * sudo docker run -t -d -p 80:5000 webapi-simple 
 

Example of requests:

 * GET /api/todo      : GetAll
 * POST /api/todo     : CreateTodoItem
 * GET /api/todo/1    : GetById
 * DELETE /api/todo/1 : DeleteItem
 * GET /api/todo/abc  : none – returns 404
 * PUT /api/todo      : none – returns 404
 
for lazy, curl examples:

	curl -i -X GET http://localhost/api/todo
	curl -i -X GET http://localhost/api/todo/1
	curl -i -X DELETE http://localhost/api/todo/1
	curl -i -X POST http://localhost/api/todo -H 'Content-Type: application/json' -d '{"Title":"WebApi + Docker","IsDone":"true"}'

## Missing Git or Docker?

* sudo apt-get install git
* sudo apt-get install docker.io
