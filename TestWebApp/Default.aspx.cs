using System;
using System.IO;
using AtellisShared.SQLite.Functions;

namespace TestWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        static readonly StringWriter Writer = new StringWriter();
        static _Default()
        {
            Console.SetOut(Writer);
            //var functionRef = new NullEqual();
            var foo = new Foo();
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            base.OnPreRenderComplete(e);
            TextArea1.Text = Writer.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //TextArea1.Text = Writer.ToString();
        }
    }
}
