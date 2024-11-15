using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.BusinessLayer.ValidationRules;
using TraversalCoreProject.DtoLayer.Dtos.AnnouncementDtos;

namespace TraversalCoreProject.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AddAnnouncementDto>, AnnouncementValidator>();
        }

    }
}
