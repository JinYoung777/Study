using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelegateBoard_Project2
{
    public class ListModel
    {
        public ListModel()
        {
        }

        private string title;
        private string content;

        /// <summary>
        /// 타이틀
        /// </summary>
        public string Title1
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 내용
        /// </summary>
        public string Content1
        {
            get { return content; }
            set { content = value; }
        }
    }

}