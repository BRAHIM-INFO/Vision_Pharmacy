
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Gui.OtherGui; 
using Vision_Pharmacy.Properties; 
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace Vision_Pharmacy.Code
{
    public static class MessageCollection
    {
        // Fields
        private static bool dialogResult;
        private static NotifictionUser notifictionUser;

        // Message Box 
        #region Message Box
        public static void ShowServerMessage()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
                MessageBox.Show(Resources_Ar.ServerConnectionCaption,
                    Resources_Ar.ServerConnectionText, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else  
                MessageBox.Show(Resources_En.ServerConnectionCaption,
                    Resources_En.ServerConnectionText, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        public static void ShowEmptyDataMessage()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
                MessageBox.Show(Resources_Ar.EmptyGridViewCaption,
                      Resources_Ar.EmptyGridViewText, MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            else MessageBox.Show(Resources_En.EmptyGridViewCaption,
                      Resources_En.EmptyGridViewText, MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
        }
        public static void ShowQuantityMessage()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
                MessageBox.Show(Resources_Ar.QuantityMaterialCaption,
                      Resources_Ar.QuantityMaterialText, MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            else MessageBox.Show(Resources_En.QuantityMaterialCaption,
                      Resources_En.QuantityMaterialText, MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
        }

        public static bool DeleteActtion()
        { 
            var resultAr = MessageBox.Show(Resources_Ar.DeleteActionCaption,
                   Resources_Ar.DeleteActionText, MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            var resultEn = MessageBox.Show(Resources_En.DeleteActionCaption,
                  Resources_En.DeleteActionText, MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);


            if (Properties.Settings.Default.ChangeLang == "Ar")
                if (resultAr == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            else
                  if (resultEn == DialogResult.Yes)
                  {
                      dialogResult = true;
                  }
                  else
                  {
                      dialogResult = false;
                  }

            return dialogResult;
        }
        public static bool OnConscinceAction()
        {

            //var resultAr = DialogResult.None;

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                var resultAr = MessageBox.Show(Resources_Ar.OutOfConscinceCaption,
                     Resources_Ar.OutOfConscinceText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultAr == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }
            else
            {
                var resultEn = MessageBox.Show(Resources_En.OutOfConscinceCaption,
                     Resources_En.OutOfConscinceText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultEn == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }

            return dialogResult;
        }
        public static bool OnDamgeAction()
        {
            //var result = MessageBox.Show(Resources.OnDamgeCaption,
            //            Resources.OnDamgeText, MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    dialogResult = true;
            //}
            //else
            //{
            //    dialogResult = false;
            //}
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                var resultAr = MessageBox.Show(Resources_Ar.OnDamgeCaption,
                     Resources_Ar.OnDamgeText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultAr == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }
            else
            {
                var resultEn = MessageBox.Show(Resources_En.OnDamgeCaption,
                     Resources_En.OnDamgeText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultEn == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }

            return dialogResult;
        }
        public static bool DeleteActtionForOutCome()
        {
            //var result = MessageBox.Show(Resources.DeletOutComeCaption,
            //            Resources.DeleteOutComeText, MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    dialogResult = true;
            //}
            //else
            //{
            //    dialogResult = false;
            //}
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                var resultAr = MessageBox.Show(Resources_Ar.DeletOutComeCaption,
                     Resources_Ar.DeleteOutComeText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultAr == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }
            else
            {
                var resultEn = MessageBox.Show(Resources_En.DeletOutComeCaption,
                     Resources_En.DeleteOutComeText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultEn == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }

            return dialogResult;
        }

        public static bool DeleteCompletedData()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                var resultAr = MessageBox.Show(Resources_Ar.ShowDeleteMaterialCaption,
                     Resources_Ar.DeleteActionText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultAr == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }
            else
            {
                var resultEn = MessageBox.Show(Resources_En.ShowDeleteMaterialCaption,
                     Resources_En.DeleteActionText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultEn == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }
            //var result = MessageBox.Show(Resources.ShowDeleteMaterialCaption,
            //            Resources.DeleteActionText, MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    dialogResult = true;
            //}
            //else
            //{
            //    dialogResult = false;
            //}
            return dialogResult;
        }

        public static bool DamageAction()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                var resultAr = MessageBox.Show(Resources_Ar.ShowMoveDamgeCaption,
                     Resources_Ar.ShowMoveDamgeText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultAr == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }
            else
            {
                var resultEn = MessageBox.Show(Resources_En.ShowMoveDamgeCaption,
                     Resources_En.ShowMoveDamgeText, MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (resultEn == DialogResult.Yes)
                {
                    dialogResult = true;
                }
                else
                {
                    dialogResult = false;
                }
            }
            //var result = MessageBox.Show(Resources.ShowMoveDamgeCaption,
            //            Resources.ShowMoveDamgeText, MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    dialogResult = true;
            //}
            //else
            //{
            //    dialogResult = false;
            //}
            return dialogResult;
        }

        public static void ShowEmptyFields()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                 MessageBox.Show(Resources_Ar.FiledsEmptyCaption,
                         Resources_Ar.FiledsEmptyText, MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }
            else
            {
                 MessageBox.Show(Resources_En.FiledsEmptyCaption,
                         Resources_En.FiledsEmptyText, MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }

        }
        public static void ShowIsSavedData()
        {

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                MessageBox.Show(Resources_Ar.SavedDataCaption,
                        Resources_Ar.SavedDataText, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources_En.SavedDataCaption,
                        Resources_En.SavedDataText, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        public static void ShowSlectRowsNotification()
        {

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                MessageBox.Show(Resources_Ar.ShowRowsCaption,
                        Resources_Ar.ShowRowText, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources_En.ShowRowsCaption,
                        Resources_En.ShowRowText, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        public static void ShowInvalidValue()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                 MessageBox.Show(Resources_Ar.InvalidInputCaption,
                         Resources_Ar.InvalidIputText, MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources_En.InvalidInputCaption,
                        Resources_En.InvalidIputText, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }

        }

        public static void ShowDuplicateData()
        {

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                MessageBox.Show(Resources_Ar.DuplicateDataCaption,
                        Resources_Ar.DuplicateDataText, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources_En.DuplicateDataCaption,
                        Resources_En.DuplicateDataText, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }


        }
        #endregion

        // Notifications
        #region Notifications
        public static void ShowAddNotification()
        {

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                notifictionUser = new NotifictionUser(Resources_Ar.AddNotificationText);
                notifictionUser.Show();
            }
            else
            {
                notifictionUser = new NotifictionUser(Resources_En.AddNotificationText);
                notifictionUser.Show();
            }

        }

        public static void ShowEditNotification()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                notifictionUser = new NotifictionUser(Resources_Ar.EditNotificationText);
                notifictionUser.Show();
            }
            else
            {
                notifictionUser = new NotifictionUser(Resources_En.EditNotificationText);
                notifictionUser.Show();
            }
        }

        public static void ShowDeletNotification()
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {

                notifictionUser = new NotifictionUser(Resources_Ar.DeleteNotificationText);
                notifictionUser.Show();
            }
            else
            {

                notifictionUser = new NotifictionUser(Resources_En.DeleteNotificationText);
                notifictionUser.Show();
            }

        }
        #endregion

    }
}
