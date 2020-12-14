using Hiver.Data.Entities;
using Hiver.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region Add Data AppUser

            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"),
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "admin@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Nguyennam1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyễn",
                    LastName = "Admin",
                    Dob = new DateTime(2020, 01, 31)
                },
                new AppUser
                {
                    Id = new Guid("A3335A51-C19B-4EC8-9DEC-39EF33E69BF7"),
                    UserName = "it",
                    NormalizedUserName = "it",
                    Email = "it@gmail.com",
                    NormalizedEmail = "it@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Nguyennam1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyễn",
                    LastName = "It",
                    Dob = new DateTime(2020, 01, 31)
                },
                new AppUser
                {
                    Id = new Guid("171F3098-762C-4B02-85C5-A687F6601DE4"),
                    UserName = "kho",
                    NormalizedUserName = "kho",
                    Email = "kho@gmail.com",
                    NormalizedEmail = "kho@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Nguyennam1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyễn",
                    LastName = "Kho",
                    Dob = new DateTime(2020, 01, 31)
                }
            );
            #endregion

            #region Add Data AppController
            modelBuilder.Entity<AppController>().HasData(
                new AppController
                {
                    Controller = "User",
                    Action = "Index",
                    Description = "Quản lý User",
                    Licensed = true
                },
                new AppController
                {
                    Controller = "Home",
                    Action = "Index",
                    Description = "Trang Chủ",
                    Licensed = true
                }
            );
            #endregion

            #region Add Data AppRoleController
            modelBuilder.Entity<AppRoleController>().HasData(
                new AppRoleController
                {
                    Id = 1,
                    Controller = "Users",
                    Action = "GetAllPaging",
                    AppUser = "admin",
                }
            );

            #endregion

            #region Add Data Role 
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                    Name = "Administrator",
                    NormalizedName = "Cấp 1",
                    Description = "Administrator role"
                }, new AppRole
                {
                    Id = new Guid("44694FAB-619C-4BCC-A8A1-4247A17905F5"),
                    Name = "BanHang",
                    NormalizedName = "Cấp 2",
                    Description = "BanHang"
                }, new AppRole
                {
                    Id = new Guid("80B0A1AC-D287-4BA3-92C4-51CBCEA55920"),
                    Name = "MuaHang",
                    NormalizedName = "Cấp 2",
                    Description = "Mua hàng"
                }, new AppRole
                {
                    Id = new Guid("2629553D-758A-460B-92CF-5C34B76A97A7"),
                    Name = "Kho",
                    NormalizedName = "Cấp 2",
                    Description = "Kho"
                },new AppRole
                {
                    Id = new Guid("7FEB5851-4244-4538-A6BD-3B98C18AFEEE"),
                    Name = "Nhansu",
                    NormalizedName = "Cấp 2",
                    Description = "Nhân Sự"
                }
            );
            #endregion

            #region Add Data RoleControllerGroup 
            modelBuilder.Entity<AppRoleControllerGroup>().HasData(
                new AppRoleControllerGroup
                {
                    Id = 1,
                    IdRole = new Guid("7FEB5851-4244-4538-A6BD-3B98C18AFEEE"),
                    Controller = "User",
                    Action = "Index"
                }, new AppRoleControllerGroup
                {
                    Id = 2,
                    IdRole = new Guid("7FEB5851-4244-4538-A6BD-3B98C18AFEEE"),
                    Controller = "User",
                    Action = "Delete"
                }, new AppRoleControllerGroup
                {
                    Id = 3,
                    IdRole = new Guid("7FEB5851-4244-4538-A6BD-3B98C18AFEEE"),
                    Controller = "User",
                    Action = "EDIT"
                }, new AppRoleControllerGroup
                {
                    Id = 4,
                    IdRole = new Guid("7FEB5851-4244-4538-A6BD-3B98C18AFEEE"),
                    Controller = "User",
                    Action = "DETAIL"
                }
            );
            #endregion

            #region Add Data Menu 
            modelBuilder.Entity<Menu>().HasData(
               new Menu
               {
                   MenuID = 1,
                   ParentID = -1,
                   MenuName = "Trang Chính",
                   Description = null,
                   Url = "/",
                   IconClass = null,
                   MenuOrder = 1,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 2,
                   ParentID = -1,
                   MenuName = "Kho",
                   Description = null,
                   Url = "/",
                   IconClass = null,
                   MenuOrder = 1,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 3,
                   ParentID = 2,
                   MenuName = "Nguyên Liệu",
                   Description = null,
                   Url = "/",
                   IconClass = null,
                   MenuOrder = 1,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 4,
                   ParentID = 2,
                   MenuName = "Thành Phẩm",
                   Description = null,
                   Url = "/",
                   IconClass = null,
                   MenuOrder = 1,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 5,
                   ParentID = -1,
                   MenuName = "Kinh Doanh",
                   Description = null,
                   Url = "/",
                   IconClass = null,
                   MenuOrder = 1,
                   IsVisible = true,
               }
           );
            #endregion


        }
    }
}