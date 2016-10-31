using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Entity
{
    // 摘要: 
    //     Defines interface for base entity type. All entities in the system must implement
    //     this interface.
    //
    // 类型参数: 
    //   TPrimaryKey:
    //     Type of the primary key of the entity
    public interface IEntity<TPrimaryKey>
    {
        // 摘要: 
        //     Unique identifier for this entity.
        TPrimaryKey Id { get; set; }

        // 摘要: 
        //     Checks if this entity is transient (not persisted to database and it has
        //     not an Abp.Domain.Entities.IEntity<TPrimaryKey>.Id).
        //
        // 返回结果: 
        //     True, if this entity is transient
        bool IsTransient();
    }
}
