using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces
{
    public interface ITestService
    {
        //This interface is use for Bussiness Rule / USE CASE
        Domain.Test GetData();
    }
}
