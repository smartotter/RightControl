﻿using RightControl.IRepository;
using RightControl.IService;
using RightControl.Model;
using System.Collections.Generic;

namespace RightControl.Service
{
    public class MenuActionService : IMenuActionService
    {
        public IMenuActionRepository repository { get; set; }
        /// <summary>
        /// 保存菜单权限配置
        /// </summary>
        /// <param name="entitys">菜单权限列表</param>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public int SavePermission(IEnumerable<MenuActionModel> entitys, int menuId)
        {
            return repository.SavePermission(entitys, menuId);
        }
    }
}