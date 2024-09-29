using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using AutoMapper;
using DAL.Repositorios.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public abstract class AbstractServices(IMapper mapper, IUnitOfWork unitOfWork)
    {
        protected readonly IUnitOfWork _unitOfWork = unitOfWork;
        protected readonly IMapper _mapper = mapper;

    }
}
