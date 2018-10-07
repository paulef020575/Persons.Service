using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Abstractions
{
    interface IQueryHandler<in TQuery, out TResult>
        where TQuery: IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
