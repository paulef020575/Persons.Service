using Nancy;
using Nancy.ModelBinding;
using Persons.Abstractions;

namespace Persons
{
    public class PostNancyModule : NancyModule
    {
        public PostNancyModule(CreatePersonCommandHandler createPersonCommandHandler)
            : base("/api/v1/persons")
        {
            Post["/"] = (param =>
            {
                CreatePersonCommand command = this.Bind<CreatePersonCommand>();

                createPersonCommandHandler.Execute(command);
                return Response.AsJson("UnprocessableEntity");
            });
        }


    }
}
