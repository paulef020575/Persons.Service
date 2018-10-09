using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using Nancy;
using Nancy.ModelBinding;
using Persons.Abstractions;
using HttpStatusCode = Nancy.HttpStatusCode;

namespace Persons
{
    public class PostNancyModule : NancyModule
    {
        public PostNancyModule(CreatePersonCommandHandler createPersonCommandHandler)
            : base("/api/v1/persons")
        {
            Post["/"] = (param =>
            {
                try
                {
                    CreatePersonCommand command = this.Bind<CreatePersonCommand>();
                    command.Id = Guid.NewGuid();

                    createPersonCommandHandler.Execute(command);
                    return new Response
                    {
                        StatusCode = HttpStatusCode.Created,
                        Headers = new Dictionary<string, string> {{"Location", $"/api/v1/persons/{command.Id}"}}
                    };
                }
                catch (ArgumentException e)
                {
                    return new Response
                    {
                        StatusCode = HttpStatusCode.UnprocessableEntity
                    };
                }
                catch (Exception e)
                {
                    return new Response
                    {
                        StatusCode = HttpStatusCode.BadRequest
                    };
                    
                }
                
            });
        }


    }
}
