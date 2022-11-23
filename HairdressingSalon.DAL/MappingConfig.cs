using AutoMapper;
using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ClientCreated, Client>();
            CreateMap<ClientUpdated, Client>();

            CreateMap<FeedbackCreated, Feedback>();
            CreateMap<FeedbackUpdated, Feedback>();

            CreateMap<OrderCreated, Order>();
            CreateMap<OrderUpdated, Order>();

            CreateMap<ServiceKindCreated, ServiceKind>();
            CreateMap<ServiceKindUpdated, ServiceKind>();

            CreateMap<ServiceCreated, Service>();
            CreateMap<ServiceUpdated, Service>();

            CreateMap<WorkerCreated, Worker>();
            CreateMap<WorkerUpdated, Worker>();
        }
    }
}
