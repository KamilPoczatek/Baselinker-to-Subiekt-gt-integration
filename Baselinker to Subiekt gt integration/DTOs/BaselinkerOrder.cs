using System.Collections.Generic;

namespace Baselinker_to_Subiekt_gt_integration
{
    class BaselinkerOrder
    {
        public string order_id;
        public string shop_order_id;
        public string external_order_id;
        public string order_source;
        public string order_source_id;
        public string order_source_info;
        public string order_status_id;
        public bool confirmed;
        public string date_confirmed;
        public string date_add;
        public string date_in_status;
        public string user_login;
        public string phone;
        public string email;
        public string user_comments;
        public string admin_comments;
        public string currency;
        public string payment_method;
        public string payment_method_cod;
        public decimal payment_done;
        public string delivery_method;
        public decimal delivery_price;
        public string delivery_package_module;
        public string delivery_package_nr;
        public string delivery_fullname;
        public string delivery_company;
        public string delivery_address;
        public string delivery_city;
        public string delivery_postcode;
        public string delivery_country_code;
        public string delivery_point_id;
        public string delivery_point_name;
        public string delivery_point_address;
        public string delivery_point_postcode;
        public string delivery_point_city;
        public string invoice_fullname;
        public string invoice_company;
        public string invoice_nip;
        public string invoice_address;
        public string invoice_city;
        public string invoice_postcode;
        public string invoice_country_code;
        public string want_invoice;
        public string extra_field_1;
        public string extra_field_2;
        public string order_page;
        public string pick_state;
        public string pack_state;
        public string delivery_country;
        public string invoice_country;
        public List <BaselinkerProduct> products;
    }
}
