using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BELayer
{
    public class clsBE
    {

		#region User Name Property:"
		public string _UserName;

        public  string UserName
			//====================
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
		#endregion

		#region "Password Property:"
		public string _Password;

        public string Password
			//===================
        {
            get { return _Password; }
            set { _Password = value; }
        }
		#endregion

		#region "User Id Property:"
		public int _UserId;

        public int UserId
			//================
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
		#endregion

		#region "User Address Property:"
		public string _UserAddress;

		public string UserAddress
		//================
		{
			get { return _UserAddress; }
			set { _UserAddress = value; }
		}
		#endregion

		#region "User Pincode Property:"
		public int _UserPincode;

		public int UserPincode
		//================
		{
			get { return _UserPincode; }
			set { _UserPincode = value; }
		}
		#endregion

		#region "User Gender Property:"
		public string _UserGender;

		public string UserGender
		//================
		{
			get { return _UserGender; }
			set { _UserGender = value; }
		}
		#endregion

		#region "User Date Of Birth Property:"
		public DateTime _UserDOB;

		public DateTime UserDOB
		//================
		{
			get { return _UserDOB; }
			set { _UserDOB = value; }
		}
		#endregion

		#region "User Contact Number Property:"
		public Int64 _UserContactNo;

		public Int64 UserContactNo
		//================
		{
			get { return _UserContactNo; }
			set { _UserContactNo = value; }
		}
		#endregion

		#region "User Email Property:"
		public string _UserEmail;

		public string UserEmail
		//================
		{
			get { return _UserEmail; }
			set { _UserEmail = value; }
		}
		#endregion

		#region "User Qualification Property:"
		public string _UserQualification;

		public string UserQualification
		//================
		{
			get { return _UserQualification; }
			set { _UserQualification = value; }
		}
		#endregion
	}
}
