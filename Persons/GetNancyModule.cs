using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Persons
{
    public class GetNancyModule : NancyModule
    {
        private GetPersonQueryHandler GetPersonQueryHandler { get; }

        public GetNancyModule(GetPersonQueryHandler getPersonQueryHandler)
            : base("/api/v1/persons")
        {
            GetPersonQueryHandler = getPersonQueryHandler;

            Get["/{person_id}"] = (param =>
            {
                GetPersonQuery query = new GetPersonQuery
                {
                    Id = param.person_id
                };

                PersonDto personDto = GetPersonQueryHandler.Handle(query);
                if (personDto != null)
                {
                    return Response.AsJson(personDto, HttpStatusCode.OK);
                }
                else
                {
                    return new Response
                    {
                        StatusCode = HttpStatusCode.NotFound
                    };
                }
            });


        }
    }
}
