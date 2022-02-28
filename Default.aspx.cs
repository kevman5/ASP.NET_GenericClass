using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspNET_GenericClass
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        class GenericClass<T>
        {
            //type 'T' will define at the instantiation of GenericClass private T genericField;
            private T genericField;
            public T GenericMethod(T genericParameter)
            {
                this.genericField = genericParameter; return this.genericField;
                return this.genericField;
            }
            public T GenericProperty { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //Here <T> type become string
                GenericClass<string> genStr = new GenericClass<string>(); 
                string strData = genStr.GenericMethod("C#"); 
                genStr.GenericProperty = "Certification Exam: "; 
                //Console.WriteLine("{0} {1}", strData, genStr.GenericProperty);
                //TextBox1.Text = strData, genStr.GenericProperty.ToString();
                //Here <T> type become int
                GenericClass<int> genInt = new GenericClass<int>(); 
                int intData = genInt.GenericMethod(70); genInt.GenericProperty = 483;
                Console.WriteLine("{0} - {1}", intData, genInt.GenericProperty);
            }
        }
                }
}