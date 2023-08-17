using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Context;
using Miles.Data.Repositories;
using Miles.Service.Profiles.Categories;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using Miles.Service.Validations.Categories;
using System.Text.Json.Serialization;

namespace Miles.App.ServiceRegistrations
{
	public static class ServiceRegister
	{
		public static void Register(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllers()?.AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<CategoryPostDtoValidation>());
			services.AddDbContext<MilesAppDbContext>(opt =>
			{
				opt.UseSqlServer(configuration.GetConnectionString("Default"));
			});
			services.AddAutoMapper(typeof(CategoryProfile));
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<ITagRepository, TagRepository>();
			services.AddScoped<ITagService, TagService>();
			services.AddScoped<IBlogRepository, BlogRepository>();
			services.AddScoped<IBlogService, BlogService>();
			services.AddScoped<IMessageRepository, MessageRepository>();
			services.AddScoped<IMessageService, MessageService>();
			services.AddScoped<IFeatureRepository, FeatureRepository>();
			services.AddScoped<IFeatureService, FeatureService>();
			services.AddScoped<IUserPricingRepository, UserPricingRepository>();
			services.AddScoped<IUserPricingService, UserPricingService>();
			services.AddScoped<IAssociateRepository, AssociateRepository>();
			services.AddScoped<IAssociateService, AssociateService>();
			services.AddScoped<ISliderRepository, SliderRepository>();
			services.AddScoped<ISliderService, SliderService>();
			services.AddScoped<ITextWhyRepository, TextWhyRepository>();
			services.AddScoped<ITextWhyService, TextWhyService>();
			services.AddScoped<ISettingRepository, SettingRepository>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IStaffRepository, StaffRepository>();
			services.AddScoped<IStaffService, StaffService>();
			services.AddScoped<ISocialRepository, SocialRepository>();
			services.AddScoped<ISocialService, SocialService>();
			services.AddScoped<IAboutTextRepository, AboutTextRepository>();
			services.AddScoped<IAboutTextService, AboutTextService>();
			services.AddScoped<IAboutSkillRepository, AboutSkillRepository>();
			services.AddScoped<IAboutSkillService, AboutSkillService>();
			services.AddScoped<IRepository<BlogCategory>, Repository<BlogCategory>>();
			services.AddScoped<IRepository<BlogTag>, Repository<BlogTag>>();
			services.AddHttpContextAccessor();

			services.AddControllers().AddJsonOptions(x =>
							x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
			services.AddSwaggerGen();
			services.AddFluentValidationRulesToSwagger();
		}
	}
}
