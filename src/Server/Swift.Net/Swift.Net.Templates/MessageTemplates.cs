﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swift.Net.Templates.Models;

namespace Swift.Net.Templates
{
    public static class MessageTemplates
    {
        public static string PoweredBy = "Powered by <a href=\"http://swiftdotnet.com\" style=\"color: #999999; font-size: 12px; text-align: center; text-decoration: none;\">Swift Dot Net</a>.";
        public static string Unsubscribe = "Don\"t like these emails? <a href=\"mailto:support@swiftdotnet.com?Subject=Unsubscribe\" style=\"text-decoration: underline; color: #999999; font-size: 12px; text-align: center;\">Unsubscribe</a>.";
        public static string CompanyName = "Swift Dot Net";
        public static string LogoURL = "https://www.swiftdotnet.com/top-logo.png";

        public static string ContactForm(ContactFormModel model)
        {

            var emailBody = "<!doctype html><html><head><meta name =\"viewport\" content=\"width=device-width\"><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"><title>Contact Form Message</title></head><body class=\"\" style=\"font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; background-color: #f6f6f6; margin: 0; padding: 0;\"><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"body\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;\" width=\"100%\" bgcolor=\"#f6f6f6\"><tr><td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\" valign=\"top\">&nbsp;</td><td class=\"container\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto !important; max-width: 580px; padding: 10px; width: 580px;\" width=\"580\" valign=\"top\"><div class=\"content\" style=\"box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;\"><!-- START CENTERED WHITE CONTAINER --><span class=\"preheader\" style=\"color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;\">" + model.Intent + ": Sender: " + model.Name + "</span><table class=\"main\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #fff; border-radius: 3px;\" width=\"100%\"><!-- START MAIN CONTENT AREA --><tr><td class=\"wrapper\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;\" valign=\"top\"><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\" width=\"100%\"><tr><td style=\"font-family: sans-serif; font-size: 16px; vertical-align: top;\" valign=\"top\"><h1 style=\"margin: 0; margin-bottom: 15px;\"><img src=\"" + LogoURL + "\" width=\"200px\" height=\"65px\" /></h1><p style=\"font-family: sans-serif; font-size: 14px; font-weight: bold; margin: 0; Margin-bottom: 15px;\">" + model.Intent + ": " + model.Subject + "</p><p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">The message was sent by " + model.Name + " (" + model.Email + ", " + model.IP + ", " + model.FQCN + "): <br/><br/>" + model.Message + "</p><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; box-sizing: border-box;\" width=\"100%\"><tbody><tr><td align=\"left\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px;\" valign=\"top\"><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: auto;\"><tbody><tr><td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; background-color: #d9230f; border-radius: 15px; text-align: center;\" valign=\"top\" bgcolor=\"#d9230f\" align=\"center\"> <a href=\"mailto:" + model.Email + "?Subject=RE:" + model.Subject + "\" target=\"_blank\" style=\"display: inline-block; color: #ffffff; background-color: #d9230f; border: solid 1px #d9230f; border-radius: 15px; box-sizing: border-box; cursor: pointer; text-decoration: none; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-transform: capitalize; border-color: #d9230f;\">Reply to Contact</a> </td></tr></tbody></table></td></tr></tbody></table></td></tr></table></td></tr><!-- END MAIN CONTENT AREA --></table><!-- START FOOTER --><div class=\"footer\" style=\"clear: both; padding-top: 10px; text-align: center; width: 100%;\"><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\" width=\"100%\"><tr><td class=\"content-block\" style=\"font-family: sans-serif; vertical-align: top; padding-top: 10px; padding-bottom: 10px; font-size: 12px; color: #999999; text-align: center;\" valign=\"top\" align=\"center\"><span class=\"apple-link\" style=\"color: #999999; font-size: 12px; text-align: center;\">" + CompanyName + "</span><br>" + Unsubscribe + "</td></tr><tr><td class=\"content-block powered-by\" style=\"font-family: sans-serif; vertical-align: top; padding-top: 10px; padding-bottom: 10px; font-size: 12px; color: #999999; text-align: center;\" valign=\"top\" align=\"center\">" + PoweredBy + "</td></tr></table></div><!-- END FOOTER --><!-- END CENTERED WHITE CONTAINER --></div></td><td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\" valign=\"top\">&nbsp;</td></tr></table></body></html>";

            return emailBody;

        }
    }
}