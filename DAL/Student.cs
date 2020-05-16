using Core._2019.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core._2019.DAL
{
  public class Student : IStudent
  {
    /// <summary>
    /// 获取学生信息
    /// </summary>
    /// <returns></returns>
    public string Info()
    {
      return "刘功葵";
    }
  }
}
