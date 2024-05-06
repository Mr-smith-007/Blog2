using AutoMapper;
using Blog2.BLL.ViewModels.User;
using Blog2.DAL.Models;
using Microsoft.AspNetCore.Identity.Data;

namespace Blog2.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegisterViewModel, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.Email))
                .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.UserName));

            //CreateMap<CommentCreateRequest, Comment>();
            //CreateMap<CommentEditRequest, Comment>();
            //CreateMap<PostCreateRequest, Post>();
            //CreateMap<PostEditViewModel, Post>();
            //CreateMap<TagCreateRequest, Tag>();
            //CreateMap<TagEditRequest, Tag>();
            CreateMap<UserEditViewModel, User>();
        }
    }
}
