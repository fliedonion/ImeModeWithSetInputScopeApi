using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace case_of_t.ImeModeWithSetInputScopeApi {
    public partial class SampleForm : Form {
        // Sample for against IME mode model per-user 

        // note of SetInputScope / SetInputScope2:
        // The application must call SetInputScope with IS_DEFAULT before a window is destroyed to clear the reference of the interface.

        public SampleForm() {
            InitializeComponent();

            Load += SampleForm_Load;
            FormClosing += SampleForm_FormClosing;
        }

        void SampleForm_Load(object sender, EventArgs e) {
             SetInputScope(textBox3.Handle, (int)itf_inputscopes.IS_KATAKANA_HALFWIDTH);
        }

        void SampleForm_FormClosing(object sender, FormClosingEventArgs e) {
            SetInputScope(textBox3.Handle, (int)itf_inputscopes.IS_DEFAULT);
        }


        [DllImport("Msctf.dll", PreserveSig = false)]
        private static extern void SetInputScope(IntPtr handle, int inputScope);


        enum itf_inputscopes : int
        {	
            IS_DEFAULT	= 0,
	        IS_URL	= 1,
	        IS_FILE_FULLFILEPATH	= 2,
	        IS_FILE_FILENAME	= 3,
	        IS_EMAIL_USERNAME	= 4,
	        IS_EMAIL_SMTPEMAILADDRESS	= 5,
	        IS_LOGINNAME	= 6,
	        IS_PERSONALNAME_FULLNAME	= 7,
	        IS_PERSONALNAME_PREFIX	= 8,
	        IS_PERSONALNAME_GIVENNAME	= 9,
	        IS_PERSONALNAME_MIDDLENAME	= 10,
	        IS_PERSONALNAME_SURNAME	= 11,
	        IS_PERSONALNAME_SUFFIX	= 12,
	        IS_ADDRESS_FULLPOSTALADDRESS	= 13,
	        IS_ADDRESS_POSTALCODE	= 14,
	        IS_ADDRESS_STREET	= 15,
	        IS_ADDRESS_STATEORPROVINCE	= 16,
	        IS_ADDRESS_CITY	= 17,
	        IS_ADDRESS_COUNTRYNAME	= 18,
	        IS_ADDRESS_COUNTRYSHORTNAME	= 19,
	        IS_CURRENCY_AMOUNTANDSYMBOL	= 20,
	        IS_CURRENCY_AMOUNT	= 21,
	        IS_DATE_FULLDATE	= 22,
	        IS_DATE_MONTH	= 23,
	        IS_DATE_DAY	= 24,
	        IS_DATE_YEAR	= 25,
	        IS_DATE_MONTHNAME	= 26,
	        IS_DATE_DAYNAME	= 27,
	        IS_DIGITS	= 28,
	        IS_NUMBER	= 29,
	        IS_ONECHAR	= 30,
	        IS_PASSWORD	= 31,
	        IS_TELEPHONE_FULLTELEPHONENUMBER	= 32,
	        IS_TELEPHONE_COUNTRYCODE	= 33,
	        IS_TELEPHONE_AREACODE	= 34,
	        IS_TELEPHONE_LOCALNUMBER	= 35,
	        IS_TIME_FULLTIME	= 36,
	        IS_TIME_HOUR	= 37,
	        IS_TIME_MINORSEC	= 38,
	        IS_NUMBER_FULLWIDTH	= 39,
	        IS_ALPHANUMERIC_HALFWIDTH	= 40,
	        IS_ALPHANUMERIC_FULLWIDTH	= 41,
	        IS_CURRENCY_CHINESE	= 42,
	        IS_BOPOMOFO	= 43,
	        IS_HIRAGANA	= 44,
	        IS_KATAKANA_HALFWIDTH	= 45,
	        IS_KATAKANA_FULLWIDTH	= 46,
	        IS_HANJA	= 47,
	        IS_HANGUL_HALFWIDTH	= 48,
	        IS_HANGUL_FULLWIDTH	= 49,
	        IS_PHRASELIST	= -1,
	        IS_REGULAREXPRESSION	= -2,
	        IS_SRGS	= -3,
	        IS_XML	= -4,
	        IS_ENUMSTRING	= -5
        }

    }
}
