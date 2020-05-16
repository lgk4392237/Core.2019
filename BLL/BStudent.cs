using Core._2019.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core._2019.BLL
{
  public class BStudent
  {
    IStudent _student;
    public BStudent(IStudent student)
    {
      _student = student;
    }
    /// <summary>
    /// 获取学生信息
    /// </summary>
    /// <returns></returns>
    public string Info()
    {
      return _student.Info()+"我试着修改东西了";
    }
  }
}
