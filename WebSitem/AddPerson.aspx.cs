using BusTicket.Business;
using BusTicket.Data.Context;
using BusTicket.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddPerson : System.Web.UI.Page
{
    PassengerBusiness busiPassenger;
    StaffBusiness busiStaff;
    PersonBusiness busiPerson;
    BusTicketContext context;
    BusBusiness busiBus;

    protected void Page_Load(object sender, EventArgs e)
    {
        busiPerson = new PersonBusiness();
        busiPassenger = new PassengerBusiness();
        busiStaff = new StaffBusiness();
        context = new BusTicketContext();
        busiBus = new BusBusiness();

        if (!IsPostBack)
        {
            gridView.DataSource = busiBus.BringAll();
            gridView.DataBind();
        }
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Passenger p = new Passenger();
        //p.IdentificationNumber = txtTC.Text;
        //p.FirstName = txtFirstName.Text;
        //p.LastName = txtLastName.Text;
        //p.Email = txtEmail.Text;
        //p.Phone = txtPhone.Text;
        //p.Password = txtPassword.Text;

        Staff k = new Staff();
        k.IdentificationNumber = txtTC.Text;
        k.FirstName = txtFirstName.Text;
        k.LastName = txtLastName.Text;
        k.Email = txtEmail.Text;
        k.Phone = txtPhone.Text;
        k.Password = txtPassword.Text;


        busiStaff.Add(k);     
    }
}