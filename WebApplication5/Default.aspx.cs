using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication5
{
    public partial class _Default : System.Web.UI.Page
    {
        ProCatEntities1 contex = new ProCatEntities1();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel4.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            //Panel2.Visible = false;
            //Panel3.Visible = false;


           // DropDownList6.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            
            if (DropDownList1.Text == "Parent")
            {
                Panel2.Visible = true;
                Panel3.Visible = false;
            }
            else
            {
                Panel3.Visible = true;
                Panel2.Visible = false;
                var categorynames = (from b in contex.Categories
                                     where b.CategoryType.Equals("Parent")
                                     select b.CategoryName).ToList();

                DropDownList2.DataSource = categorynames;
                //  DropDownList6.DataSource = categorynames;
                DropDownList2.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            Panel5.Visible = false;
            Label7.Visible = false;
            DropDownList5.Visible = false;
           // Button9.Visible = true;
            //Button11.Visible = false;

            Label11.Visible = false;
            DropDownList7.Visible = false;


            Label10.Visible = true;
            TextBox4.Visible = true;
        }

        //protected void Button10_Click(object sender, EventArgs e)
        //{

        //}

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            if (DropDownList3.Text == "Parent")
            {
                Panel5.Visible = true;
                Button15.Visible=false;
               // Panel5.Visible = false;
                Label7.Visible = false;
                DropDownList5.Visible = false;
            }
           else
           {
                Panel5.Visible = true;
                Label7.Visible = true;
                Button15.Visible = true;
                DropDownList5.Visible = true;
           }
            var categorynames = (from b in contex.Categories
                                 where b.CategoryType.Equals("Parent")
                                 select b.CategoryName).ToList();

            DropDownList4.DataSource = categorynames;
            DropDownList4.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            //Button9.Visible = false;
            //Button11.Visible = true;
            Panel5.Visible = false;
            Label7.Visible = false;
            DropDownList5.Visible = false;

            Label11.Visible = true;
            DropDownList7.Visible = true;

            Label10.Visible = false;
            TextBox4.Visible = false;

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Panel6.Visible = true;
            GridView1.Visible = false;
            var categorynames = (from b in contex.Categories
                                 where b.CategoryType.Equals("Parent")
                                 select b.CategoryName).ToList();

           
            DropDownList6.DataSource = categorynames;
           
            DropDownList6.DataBind();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Panel6.Visible = true;
            GridView1.Visible = true;
            string a = null;
            String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=ProCat;Integrated Security=True";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList6.SelectedValue + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                a = dr[0].ToString();
            }
            dr.Close();
            int c = int.Parse(a);
            var categorynames = (from b in contex.Categories
                                 where b.ParentCategoryId == c
                                 select b.CategoryName).ToList();

            GridView1.DataSource = categorynames;
            GridView1.DataBind();
        }

        protected void Button3_Click2(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            GridView1.Visible = false;
            var categorynames = (from b in contex.Categories
                                 where b.CategoryType.Equals("Parent")
                                 select b.CategoryName).ToList();

            DropDownList8.DataSource = categorynames;

            DropDownList8.DataBind();
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            GridView2.Visible = true;
            string a = null;
            String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=ProCat;Integrated Security=True";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList8.SelectedValue + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                a = dr[0].ToString();
            }
            dr.Close();
            int c = int.Parse(a);
            var categorynames = (from b in contex.Products
                                 where b.ParentId == c
                                 select new { b.ProdName, b.Price }).ToList();

            GridView2.DataSource = categorynames;
            GridView2.DataBind();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           
            Category obj = new Category();
            obj.CategoryName = TextBox2.Text;
            obj.CategoryType = DropDownList1.Text;
            contex.Categories.AddObject(obj);
            
            contex.SaveChanges();


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string a=null;
            String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=ProCat;Integrated Security=True";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList2.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                 a = dr[0].ToString();
            }
            dr.Close();
            SqlCommand cm = new SqlCommand("select CategoryName,ParentCategoryId from Category where ParentCategoryId='" + int.Parse(a) + "'and CategoryName = '" + TextBox3.Text + "'", con);
            SqlDataReader dr1 = cm.ExecuteReader();
            
            if (dr1.Read())
            {
                Response.Write("<script>alert('Child Category allready exists');</script>");
            }
            else
            {

                //ProCatEntities1 contex = new ProCatEntities1();  
                //var a = (from b in contex.Categories
                //         where b.CategoryType.Equals("Parent") && b.CategoryName.Equals(DropDownList2.Text)
                //         select b.Id);


                Category obj = new Category();
                obj.CategoryName = TextBox3.Text;
                obj.CategoryType = DropDownList1.Text;
                obj.ParentCategoryId = int.Parse(a);

                contex.Categories.AddObject(obj);

                contex.SaveChanges();
            }


        }

        //protected void DropDownList5_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        protected void Button15_Click(object sender, EventArgs e)
        {
            DropDownList5.Items.Clear();
            Panel4.Visible = true;
            string a = null;
            String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=ProCat;Integrated Security=True";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList4.SelectedValue + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                a = dr[0].ToString();
            }
            dr.Close();
            int c = int.Parse(a);
            var categorynames = (from b in contex.Categories
                                 where b.ParentCategoryId == c
                                 select b.CategoryName).ToList();

            DropDownList5.DataSource = categorynames;

            DropDownList5.DataBind();
           
        }

        //protected void Button11_Click(object sender, EventArgs e)
        //{
        //    Panel4.Visible = true;
        //    string a = null , b=null;
        //    String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=ProCat;Integrated Security=True";
        //    SqlConnection con = new SqlConnection(CS);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList4.SelectedValue + "'", con);

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        a = dr[0].ToString();
        //    }
        //    dr.Close();
        //    SqlCommand cmd1 = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList4.SelectedValue + "'", con);

        //    SqlDataReader dr1 = cmd.ExecuteReader();
        //    if (dr1.Read())
        //    {
        //        b = dr1[0].ToString();
        //    }
        //    dr1.Close();

        //    Product obj = new Product();
        //    obj.ProdName = TextBox4.Text;
        //    obj.Price =Convert.ToDecimal(TextBox5.Text);
        //    obj.ParentId = int.Parse(a);
        //    obj.ChidId = int.Parse(b);
        //    contex.Products.AddObject(obj);

        //    contex.SaveChanges();


        //}

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            string a = null, b = null;
            String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=ProCat;Integrated Security=True";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList4.SelectedValue + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                a = dr[0].ToString();
            }
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("select Id from Category where CategoryType = 'Parent' and CategoryName='" + DropDownList4.SelectedValue + "'", con);

            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                b = dr1[0].ToString();
            }
            dr1.Close();

            Product obj = new Product();
            obj.ProdName = TextBox4.Text;
            obj.Price = Convert.ToDecimal(TextBox5.Text);
            obj.ParentId = int.Parse(a);
            obj.ChidId = int.Parse(b);
            contex.Products.AddObject(obj);

            contex.SaveChanges();
        }
    }
}
