﻿namespace Memorabilia.Domain.Entities;

public class RolePermission : Entity
{
    public RolePermission() { }

    public RolePermission(int permissionId,
                          int roleId)
    {
        PermissionId = permissionId;
        RoleId = roleId;
    }

    public int PermissionId { get; private set; }

    public int RoleId { get; private set; }
}
