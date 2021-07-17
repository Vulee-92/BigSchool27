using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool27.Models
{
    public partial class Course
    {
        public List<Category> ListCategory = new List<Category>();
        public string Name;
        public string LectureName;
        public bool isLogin = false;
        public bool isShowGoing = false;
        public bool isShowFollow = false;
    }
}