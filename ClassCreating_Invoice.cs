using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassCreating_Invoice
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Create_Invoice_add(
                                      int Create_Invoice_Id  /*رقم إنشاء الموظف*/
                                    , int InvoiceID  /*رقم الفاتوره*/
                                    , int InvoiceDate  /*تاريخ الفاتوره*/
                                    , int Type  /*النوع*/
                                    , int currency  /*العمله*/
                                    , int CurrencyVal  /*قيمه العمله*/
                                    , int Warehouse  /*المستودع*/
                                    , int refe  /*المرجع*/
                                    , int SupAddress  /*العنوان*/
                                    , int Sup  /*المورد*/
                                    , int SupMobile  /*جوال المورد*/
                                    , int Sal_Name  /*إسم المندوب*/
                                    //, int product  /*المنتج*/
                                    , int ProQty  /*الكميه المتوفره*/
                                    , int supbalance  /*رصيد المورد*/
                                    , int Note  /*ملاحظه*/
                                    , int Orders  /*طلبيات الجوال*/
                                    , int dis_percent  /*خصم على الصافي بالنسبه الخانه*/
                                    , int dis_num  /*خصم على الصافي رقماً الخانه*/
                                    , int plus_persent  /* الخانه زيادة على الصافي نسبه*/
                                    , int plus_num  /*الخانه زياده على الصافي رقماً*/
                                    , int TotalProCost   /*الإجمالي*/
                                    , int Net  /*صافي*/
                                    , int DiscountTotal  /*إجمالي الخصم*/
                                    , int AdditionalCost  /*الإضافات*/
                                    , int VAT  /*القيمة الإضافيه*/
                                    , int LastTotal  /*القيمه المطلوبه*/
                                    , bool pro_name  /*إسم المنتج*/
                                    , bool pro_qty  /*الكميه*/
                                    , bool pro_price  /*السعر*/
                                    , bool pro_total  /*الإجمالي*/
                                    , bool pur_gift  /*الهديه*/
                                    , bool pur_perplus  /*الزيادة%*/
                                    , bool pur_permin  /*%الخصم*/
                                    , bool pro_cost  /*التكلفه*/
                                    , bool pro_discount
                                    , bool pro_additionalCost
                                    , bool pro_avgcost
                                    , bool pro_vat
                                    , int btn_Addinv   /*زر الإضافه*/
                                    , int btn_Updateinv  /*زر التعديل*/
                                    , int btn_Delinv  /*زر الحذف*/
                                    , int btn_Printinv  /*زر الطباعه*/
                                    , int btn_Searchinv  /*زر البحث*/
                                    , int Invoice_Type_id
                                    , string CreatingInvoice_Type /*نوع إنشاء الفاتورة*/
                                    , int SupID /*رقم المورد*/
                                    , int tb_dis_percent /*خصم على الصافي بالنسبه  */
                                    , int tb_dis_num /*خصم على الصافي رقماً  */
                                    , int tb_plus_persent /* زيادة على الصافي نسبه*/
                                    , int tb_plus_num /* زياده على الصافي رقماً*/
                                    , string cb_Warehouse /*المستودع*/
                                    , string cb_currency /* العمله*/
                                    , int branch_id /*رقم الفرع*/
                                    , string branch_name /*إسم الفرع*/
                                    , string PriceDef_id /*رقم السعر الافتراضي*/
                                    , string PriceDef /*السعر الإفتراضي*/
                                    , string CostDef_id /*رقم التكلفه الإفتراضي*/
                                    , string CostDef /*  التكلفه الإفتراضي*/
                                    , int Entry_Issue /*اصدار القيد تلقائي*/
                                    , string Invoice_Name_Ar /*إسم الفاتورة بالعربي*/
                                    , string Invoice_Name_Eng /*إسم الفاتورة بالانجليزي*/
                                    , byte[] Invoice_Icone /*إيقونه*/
                                    , int Entry_status/*حاله القيد*/
                                    , int Qid /*خانه القيد*/
                                    , int branch /*خانه الفرع*/
                                    , int cb_PriceDef /*خانه السعر الإفتراضي*/
                                    , int cb_CostDef /*خانه التكلفه الإفتراضي*/
                                    //, int reduce_Qyt /*خانه إنقاص الكميه*/
                                    //, int Increase_Qty /*خانه زيادة الكميه*/
                                    //, int late /*خانه عدم التاخير*/
                                    , int InvoiceTo_Id /*خانه رقم ربط السند*/
                                    , string InvoiceTo /*  ربط السند*/
                                    , int cb_InvoiceTo /*خانه ربط السند*/
                                    , int QtyState /*تأثير الكمية*/
                                    , int Inv_Type_Id /*رقم النوع*/
                                    , string Inv_Type /*النوع*/
                                    , int costCenter_Id /*رقم مركز التكلفة */
                                    , string CostCenter /*إسم مركز التكلفه*/
                                    , int Costcenter_def /*خانة مركز التكلفة */
                                    , int OutOfStock /*خانة سحب الكمية بالسالب */
                                    , int SellingBlowCost /*خانة البيع بأقل من التكلفة */
                                    , int ItemDuplication /*خانة التكرار في الفاتورة */
                                    , int Customer /*خانة الزبون */
                                    , int Payment_Methods_Id /*نوع الدفع */
                                    , string Payment_Methods /*نوع الدفع*/
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date
                                    //------------------------------------------------
                                    , decimal vat_val /* قيمة vat*/
                                    , int BeneficiaryAcc_id /*رقم حساب المستفيد*/
                                    , string BeneficiaryAcc /*حساب المستفيد */
                                    , int cb_BeneficiaryAcc /*خانة حساب المستفيد*/
                                    , int cb_QtyCost_State /*التأثير على تكلفه الصنف*/
                                    , int AddingCost_id /*رقم تكاليف إضافات الفاتورة*/
                                    , string AddingCost /* تكاليف إضافات الفاتورة*/
                                    /*, int default_print_id /*رقم الطباعة الإفتراضي*/
                                    , string Print_1 /* شكل الطباعة 1*/
                                    , string Print_2 /* 2 شكل الطباعة*/
                                    , string inv_Description/*النص*/

                                                           )
        {
            SqlParameter[] para = new SqlParameter[95];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[1] = new SqlParameter("@InvoiceID", InvoiceID);
            para[2] = new SqlParameter("@InvoiceDate", InvoiceDate);
            para[3] = new SqlParameter("@Type", Type);
            para[4] = new SqlParameter("@currency", currency);
            para[5] = new SqlParameter("@CurrencyVal", CurrencyVal);
            para[6] = new SqlParameter("@Warehouse", Warehouse);
            para[7] = new SqlParameter("@refe", refe);
            para[8] = new SqlParameter("@SupAddress", SupAddress);
            para[9] = new SqlParameter("@Sup", Sup);
            para[10] = new SqlParameter("@SupMobile", SupMobile);
            para[11] = new SqlParameter("@Sal_Name", Sal_Name);
            //para[12] = new SqlParameter("@product", product);
            para[12] = new SqlParameter("@ProQty", ProQty);
            para[13] = new SqlParameter("@supbalance", supbalance);
            para[14] = new SqlParameter("@Note", Note);
            para[15] = new SqlParameter("@Orders", Orders);
            para[16] = new SqlParameter("@dis_percent", dis_percent);
            para[17] = new SqlParameter("@dis_num", dis_num);
            para[18] = new SqlParameter("@plus_persent", plus_persent);
            para[19] = new SqlParameter("@plus_num", plus_num);
            para[20] = new SqlParameter("@TotalProCost", TotalProCost);
            para[21] = new SqlParameter("@Net", Net);
            para[22] = new SqlParameter("@DiscountTotal", DiscountTotal);
            para[23] = new SqlParameter("@AdditionalCost", AdditionalCost);
            para[24] = new SqlParameter("@VAT", VAT);
            para[25] = new SqlParameter("@LastTotal", LastTotal);
            para[26] = new SqlParameter("@pro_name", pro_name);
            para[27] = new SqlParameter("@pro_qty", pro_qty);
            para[28] = new SqlParameter("@pro_price", pro_price);
            para[29] = new SqlParameter("@pro_total", pro_total);
            para[30] = new SqlParameter("@pur_gift", pur_gift);
            para[31] = new SqlParameter("@pur_perplus", pur_perplus);
            para[32] = new SqlParameter("@pur_permin", pur_permin);
            para[33] = new SqlParameter("@pro_cost", pro_cost);
            para[34] = new SqlParameter("@pro_discount", pro_discount);
            para[35] = new SqlParameter("@pro_additionalCost", pro_additionalCost);
            para[36] = new SqlParameter("@pro_avgcost", pro_avgcost);
            para[37] = new SqlParameter("@pro_vat", pro_vat);
            para[38] = new SqlParameter("@btn_Addinv", btn_Addinv);
            para[39] = new SqlParameter("@btn_Updateinv", btn_Updateinv);
            para[40] = new SqlParameter("@btn_Delinv", btn_Delinv);
            para[41] = new SqlParameter("@btn_Printinv", btn_Printinv);
            para[42] = new SqlParameter("@btn_Searchinv", btn_Searchinv);
            para[43] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);
            para[44] = new SqlParameter("@CreatingInvoice_Type", CreatingInvoice_Type);
            para[45] = new SqlParameter("@SupID", SupID);
            para[46] = new SqlParameter("@tb_dis_percent", tb_dis_percent);
            para[47] = new SqlParameter("@tb_dis_num", tb_dis_num);
            para[48] = new SqlParameter("@tb_plus_persent", tb_plus_persent);
            para[49] = new SqlParameter("@tb_plus_num", tb_plus_num);
            para[50] = new SqlParameter("@cb_Warehouse", cb_Warehouse);
            para[51] = new SqlParameter("@cb_currency", cb_currency);
            para[52] = new SqlParameter("@branch_id", branch_id);
            para[53] = new SqlParameter("@branch_name", branch_name);
            para[54] = new SqlParameter("@PriceDef_id", PriceDef_id);
            para[55] = new SqlParameter("@PriceDef", PriceDef);
            para[56] = new SqlParameter("@CostDef_id", CostDef_id);
            para[57] = new SqlParameter("@CostDef", CostDef);
            para[58] = new SqlParameter("@Entry_Issue", Entry_Issue);
            para[59] = new SqlParameter("@Invoice_Name_Ar", Invoice_Name_Ar);
            para[60] = new SqlParameter("@Invoice_Name_Eng", Invoice_Name_Eng);
            para[61] = new SqlParameter("@Invoice_Icone", Invoice_Icone);
            para[62] = new SqlParameter("@Entry_status", Entry_status);
            para[63] = new SqlParameter("@Qid", Qid);
            para[64] = new SqlParameter("@branch", branch);
            para[65] = new SqlParameter("@cb_PriceDef", cb_PriceDef);
            para[66] = new SqlParameter("@cb_CostDef", cb_CostDef);
            para[67] = new SqlParameter("@InvoiceTo_Id", InvoiceTo_Id);
            para[68] = new SqlParameter("@InvoiceTo", InvoiceTo);
            para[69] = new SqlParameter("@cb_InvoiceTo", cb_InvoiceTo);
            para[70] = new SqlParameter("@QtyState", QtyState);
            para[71] = new SqlParameter("@Inv_Type_Id", Inv_Type_Id);
            para[72] = new SqlParameter("@Inv_Type", Inv_Type);
            para[73] = new SqlParameter("@costCenter_Id", costCenter_Id);
            para[74] = new SqlParameter("@CostCenter", CostCenter);
            para[75] = new SqlParameter("@Costcenter_def", Costcenter_def);
            para[76] = new SqlParameter("@OutOfStock", OutOfStock);
            para[77] = new SqlParameter("@SellingBlowCost", SellingBlowCost);
            para[78] = new SqlParameter("@ItemDuplication", ItemDuplication);
            para[79] = new SqlParameter("@Customer", Customer);
            para[80] = new SqlParameter("@Payment_Methods_Id", Payment_Methods_Id);
            para[81] = new SqlParameter("@Payment_Methods", Payment_Methods);
            //Created By & Created Date
            para[82] = new SqlParameter("@Created_By", Created_By);
            para[83] = new SqlParameter("@Created_Date", Created_Date);
            //---------------------------------------------------------
            para[84] = new SqlParameter("@vat_val", vat_val);
            para[85] = new SqlParameter("@BeneficiaryAcc_id", BeneficiaryAcc_id);
            para[86] = new SqlParameter("@BeneficiaryAcc", BeneficiaryAcc);
            para[87] = new SqlParameter("@cb_BeneficiaryAcc", cb_BeneficiaryAcc);
            para[88] = new SqlParameter("@cb_QtyCost_State", cb_QtyCost_State);
            para[89] = new SqlParameter("@AddingCost_id", AddingCost_id);
            para[90] = new SqlParameter("@AddingCost", AddingCost);
            /*para[90] = new SqlParameter("@default_print_id", default_print_id);*/
            para[91] = new SqlParameter("@Print_1", Print_1);
            para[92] = new SqlParameter("@Print_2", Print_2);
            para[93] = new SqlParameter("@inv_Description", inv_Description);
            //---------------------------------------------------------
            para[94] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_Create_Invoice", para);
            dtac.close();
        }


        public void mng_Create_Invoice_Update(
                                      int Create_Invoice_Id  /*رقم إنشاء الموظف*/
                                    , int InvoiceID  /*رقم الفاتوره*/
                                    , int InvoiceDate  /*تاريخ الفاتوره*/
                                    , int Type  /*النوع*/
                                    , int currency  /*العمله*/
                                    , int CurrencyVal  /*قيمه العمله*/
                                    , int Warehouse  /*المستودع*/
                                    , int refe  /*المرجع*/
                                    , int SupAddress  /*العنوان*/
                                    , int Sup  /*المورد*/
                                    , int SupMobile  /*جوال المورد*/
                                    , int Sal_Name  /*إسم المندوب*/
                                    //, int product  /*المنتج*/
                                    , int ProQty  /*الكميه المتوفره*/
                                    , int supbalance  /*رصيد المورد*/
                                    , int Note  /*ملاحظه*/
                                    , int Orders  /*طلبيات الجوال*/
                                    , int dis_percent  /*خصم على الصافي بالنسبه الخانه*/
                                    , int dis_num  /*خصم على الصافي رقماً الخانه*/
                                    , int plus_persent  /* الخانه زيادة على الصافي نسبه*/
                                    , int plus_num  /*الخانه زياده على الصافي رقماً*/
                                    , int TotalProCost   /*الإجمالي*/
                                    , int Net  /*صافي*/
                                    , int DiscountTotal  /*إجمالي الخصم*/
                                    , int AdditionalCost  /*الإضافات*/
                                    , int VAT  /*القيمة الإضافيه*/
                                    , int LastTotal  /*القيمه المطلوبه*/
                                    , bool pro_name  /*إسم المنتج*/
                                    , bool pro_qty  /*الكميه*/
                                    , bool pro_price  /*السعر*/
                                    , bool pro_total  /*الإجمالي*/
                                    , bool pur_gift  /*الهديه*/
                                    , bool pur_perplus  /*الزيادة%*/
                                    , bool pur_permin  /*%الخصم*/
                                    , bool pro_cost  /*التكلفه*/
                                    , bool pro_discount
                                    , bool pro_additionalCost
                                    , bool pro_avgcost
                                    , bool pro_vat
                                    , int btn_Addinv   /*زر الإضافه*/
                                    , int btn_Updateinv  /*زر التعديل*/
                                    , int btn_Delinv  /*زر الحذف*/
                                    , int btn_Printinv  /*زر الطباعه*/
                                    , int btn_Searchinv  /*زر البحث*/
                                    , int Invoice_Type_id
                                    , string CreatingInvoice_Type /*نوع إنشاء الفاتورة*/
                                    , int SupID /*رقم المورد*/
                                    , int tb_dis_percent /*خصم على الصافي بالنسبه  */
                                    , int tb_dis_num /*خصم على الصافي رقماً  */
                                    , int tb_plus_persent /* زيادة على الصافي نسبه*/
                                    , int tb_plus_num /* زياده على الصافي رقماً*/
                                    , string cb_Warehouse /*المستودع*/
                                    , string cb_currency /* العمله*/
                                    , int branch_id /*رقم الفرع*/
                                    , string branch_name /*إسم الفرع*/
                                    , string PriceDef_id /*رقم السعر الافتراضي*/
                                    , string PriceDef /*السعر الإفتراضي*/
                                    , string CostDef_id /*رقم التكلفه الإفتراضي*/
                                    , string CostDef /*  التكلفه الإفتراضي*/
                                    , int Entry_Issue /*اصدار القيد تلقائي*/
                                    , string Invoice_Name_Ar /*إسم الفاتورة بالعربي*/
                                    , string Invoice_Name_Eng /*إسم الفاتورة بالانجليزي*/
                                    , byte[] Invoice_Icone /*إيقونه*/
                                    , int Entry_status/*حاله القيد*/
                                    , int Qid /*خانه القيد*/
                                    , int branch /*خانه الفرع*/
                                    , int cb_PriceDef /*خانه السعر الإفتراضي*/
                                    , int cb_CostDef /*خانه التكلفه الإفتراضي*/
                                    //, int reduce_Qyt /*خانه إنقاص الكميه*/
                                    //, int Increase_Qty /*خانه زيادة الكميه*/
                                    //, int late /*خانه عدم التاخير*/
                                    , int InvoiceTo_Id /*خانه رقم ربط السند*/
                                    , string InvoiceTo /*  ربط السند*/
                                    , int cb_InvoiceTo /*خانه ربط السند*/
                                    , int QtyState /*تأثير الكمية*/
                                    , int Inv_Type_Id /*رقم النوع*/
                                    , string Inv_Type /*النوع*/
                                    , int costCenter_Id /*رقم مركز التكلفة */
                                    , string CostCenter /*إسم مركز التكلفه*/
                                    , int Costcenter_def /*خانة مركز التكلفة */
                                    , int OutOfStock /*خانة سحب الكمية بالسالب */
                                    , int SellingBlowCost /*خانة البيع بأقل من التكلفة */
                                    , int ItemDuplication /*خانة التكرار في الفاتورة */
                                    , int Customer /*خانة الزبون */
                                    , int Payment_Methods_Id /*نوع الدفع */
                                    , string Payment_Methods /*نوع الدفع*/
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date
                                    //------------------------------------------------
                                    , decimal vat_val /* قيمة vat*/
                                    , int BeneficiaryAcc_id /*رقم حساب المستفيد*/
                                    , string BeneficiaryAcc /*حساب المستفيد */
                                    , int cb_BeneficiaryAcc /*خانة حساب المستفيد*/
                                    , int cb_QtyCost_State /*التأثير على تكلفه الصنف*/
                                    , int AddingCost_id /*رقم تكاليف إضافات الفاتورة*/
                                    , string AddingCost /* تكاليف إضافات الفاتورة*/
                                    /*, int default_print_id /*رقم الطباعة الإفتراضي*/
                                    , string Print_1 /* شكل الطباعة 1*/
                                    , string Print_2 /* 2 شكل الطباعة*/
                                    , string inv_Description/*النص*/


                                                           )
        {
            SqlParameter[] para = new SqlParameter[95];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[1] = new SqlParameter("@InvoiceID", InvoiceID);
            para[2] = new SqlParameter("@InvoiceDate", InvoiceDate);
            para[3] = new SqlParameter("@Type", Type);
            para[4] = new SqlParameter("@currency", currency);
            para[5] = new SqlParameter("@CurrencyVal", CurrencyVal);
            para[6] = new SqlParameter("@Warehouse", Warehouse);
            para[7] = new SqlParameter("@refe", refe);
            para[8] = new SqlParameter("@SupAddress", SupAddress);
            para[9] = new SqlParameter("@Sup", Sup);
            para[10] = new SqlParameter("@SupMobile", SupMobile);
            para[11] = new SqlParameter("@Sal_Name", Sal_Name);
            //para[12] = new SqlParameter("@product", product);
            para[12] = new SqlParameter("@ProQty", ProQty);
            para[13] = new SqlParameter("@supbalance", supbalance);
            para[14] = new SqlParameter("@Note", Note);
            para[15] = new SqlParameter("@Orders", Orders);
            para[16] = new SqlParameter("@dis_percent", dis_percent);
            para[17] = new SqlParameter("@dis_num", dis_num);
            para[18] = new SqlParameter("@plus_persent", plus_persent);
            para[19] = new SqlParameter("@plus_num", plus_num);
            para[20] = new SqlParameter("@TotalProCost", TotalProCost);
            para[21] = new SqlParameter("@Net", Net);
            para[22] = new SqlParameter("@DiscountTotal", DiscountTotal);
            para[23] = new SqlParameter("@AdditionalCost", AdditionalCost);
            para[24] = new SqlParameter("@VAT", VAT);
            para[25] = new SqlParameter("@LastTotal", LastTotal);
            para[26] = new SqlParameter("@pro_name", pro_name);
            para[27] = new SqlParameter("@pro_qty", pro_qty);
            para[28] = new SqlParameter("@pro_price", pro_price);
            para[29] = new SqlParameter("@pro_total", pro_total);
            para[30] = new SqlParameter("@pur_gift", pur_gift);
            para[31] = new SqlParameter("@pur_perplus", pur_perplus);
            para[32] = new SqlParameter("@pur_permin", pur_permin);
            para[33] = new SqlParameter("@pro_cost", pro_cost);
            para[34] = new SqlParameter("@pro_discount", pro_discount);
            para[35] = new SqlParameter("@pro_additionalCost", pro_additionalCost);
            para[36] = new SqlParameter("@pro_avgcost", pro_avgcost);
            para[37] = new SqlParameter("@pro_vat", pro_vat);
            para[38] = new SqlParameter("@btn_Addinv", btn_Addinv);
            para[39] = new SqlParameter("@btn_Updateinv", btn_Updateinv);
            para[40] = new SqlParameter("@btn_Delinv", btn_Delinv);
            para[41] = new SqlParameter("@btn_Printinv", btn_Printinv);
            para[42] = new SqlParameter("@btn_Searchinv", btn_Searchinv);
            para[43] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);
            para[44] = new SqlParameter("@CreatingInvoice_Type", CreatingInvoice_Type);
            para[45] = new SqlParameter("@SupID", SupID);
            para[46] = new SqlParameter("@tb_dis_percent", tb_dis_percent);
            para[47] = new SqlParameter("@tb_dis_num", tb_dis_num);
            para[48] = new SqlParameter("@tb_plus_persent", tb_plus_persent);
            para[49] = new SqlParameter("@tb_plus_num", tb_plus_num);
            para[50] = new SqlParameter("@cb_Warehouse", cb_Warehouse);
            para[51] = new SqlParameter("@cb_currency", cb_currency);
            para[52] = new SqlParameter("@branch_id", branch_id);
            para[53] = new SqlParameter("@branch_name", branch_name);
            para[54] = new SqlParameter("@PriceDef_id", PriceDef_id);
            para[55] = new SqlParameter("@PriceDef", PriceDef);
            para[56] = new SqlParameter("@CostDef_id", CostDef_id);
            para[57] = new SqlParameter("@CostDef", CostDef);
            para[58] = new SqlParameter("@Entry_Issue", Entry_Issue);
            para[59] = new SqlParameter("@Invoice_Name_Ar", Invoice_Name_Ar);
            para[60] = new SqlParameter("@Invoice_Name_Eng", Invoice_Name_Eng);
            para[61] = new SqlParameter("@Invoice_Icone", Invoice_Icone);
            para[62] = new SqlParameter("@Entry_status", Entry_status);
            para[63] = new SqlParameter("@Qid", Qid);
            para[64] = new SqlParameter("@branch", branch);
            para[65] = new SqlParameter("@cb_PriceDef", cb_PriceDef);
            para[66] = new SqlParameter("@cb_CostDef", cb_CostDef);
            para[67] = new SqlParameter("@InvoiceTo_Id", InvoiceTo_Id);
            para[68] = new SqlParameter("@InvoiceTo", InvoiceTo);
            para[69] = new SqlParameter("@cb_InvoiceTo", cb_InvoiceTo);
            para[70] = new SqlParameter("@QtyState", QtyState);
            para[71] = new SqlParameter("@Inv_Type_Id", Inv_Type_Id);
            para[72] = new SqlParameter("@Inv_Type", Inv_Type);
            para[73] = new SqlParameter("@costCenter_Id", costCenter_Id);
            para[74] = new SqlParameter("@CostCenter", CostCenter);
            para[75] = new SqlParameter("@Costcenter_def", Costcenter_def);
            para[76] = new SqlParameter("@OutOfStock", OutOfStock);
            para[77] = new SqlParameter("@SellingBlowCost", SellingBlowCost);
            para[78] = new SqlParameter("@ItemDuplication", ItemDuplication);
            para[79] = new SqlParameter("@Customer", Customer);
            para[80] = new SqlParameter("@Payment_Methods_Id", Payment_Methods_Id);
            para[81] = new SqlParameter("@Payment_Methods", Payment_Methods);
            //Created By & Created Date
            para[82] = new SqlParameter("@Created_By", Created_By);
            para[83] = new SqlParameter("@Created_Date", Created_Date);
            //---------------------------------------------------------
            para[84] = new SqlParameter("@vat_val", vat_val);
            para[85] = new SqlParameter("@BeneficiaryAcc_id", BeneficiaryAcc_id);
            para[86] = new SqlParameter("@BeneficiaryAcc", BeneficiaryAcc);
            para[87] = new SqlParameter("@cb_BeneficiaryAcc", cb_BeneficiaryAcc);
            para[88] = new SqlParameter("@cb_QtyCost_State", cb_QtyCost_State);
            para[89] = new SqlParameter("@AddingCost_id", AddingCost_id);
            para[90] = new SqlParameter("@AddingCost", AddingCost);
            /*para[90] = new SqlParameter("@default_print_id", default_print_id);*/
            para[91] = new SqlParameter("@Print_1", Print_1);
            para[92] = new SqlParameter("@Print_2", Print_2);
            para[93] = new SqlParameter("@inv_Description", inv_Description);
            //---------------------------------------------------------
            para[94] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Create_Invoice", para);
            dtac.close();
        }
        //الحذف
        public void mng_Create_InvoiceDel(int Create_Invoice_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);

            dtac.open();
            dtac.ExcutCommand("mng_Create_InvoiceDel", para);
            dtac.close();
        }
        //لعرض خانات الاختيار في الجريد
        public DataTable ShowCreateInvoice(/*int Create_Invoice_Id*/)
        {
            //SqlParameter[] para = new SqlParameter[1];
            //para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCreateInvoice", null);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchCreateInvoice(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchCreateInvoice", para);
            dtac.close();
            return dt;
        }
        // لإظهار جميع الحقول بناءا على رقم الفاتورة
        public DataTable ShowCreateInvoice_All(int Create_Invoice_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCreateInvoice_All", para);
            dtac.close();
            return dt;
        }
        //للحصول على الرقم التسلسي
        public DataTable Get_CreatingVoice()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_CreatingVoice", null);
            dtac.close();
            return dt;
        }
        //لإظهار جميع الحقول 
        public DataTable GetAllCreateInvoice()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetAllCreateInvoice", null);
            dtac.close();
            return dt;
        }
        public DataTable Inv_name( string CreatingInvoice_Type)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@CreatingInvoice_Type", CreatingInvoice_Type);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Inv_name", para);
            dtac.close();
            return dt;
        }
        //لإظهار الفواتير (رقم إنشاء الفاتورة, رقم نوع الفاتورة, نوع الفاتورة, أسم الفاتورة بالعربي, إسم الفاتورة بالإنجليزي)
        public DataTable Show_AllInvoiceTypes()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_AllInvoiceTypes", null);
            dtac.close();
            return dt;
        }
    }
}
