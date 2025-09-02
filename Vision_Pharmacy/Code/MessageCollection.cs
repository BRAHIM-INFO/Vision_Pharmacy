
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Properties;
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
            //var result = MessageBox.Show(Resources.OutOfConscinceCaption,
            //            Resources.OutOfConscinceText, MessageBoxButtons.YesNo,
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
            return dialogResult;
        }

        public static bool DeleteCompletedData()
        {
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
            //MessageBox.Show(Resources.FiledsEmptyCaption,
            //        Resources.FiledsEmptyText, MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
        }
        public static void ShowIsSavedData()
        {
            //MessageBox.Show(Resources.SavedDataCaption,
            //        Resources.SavedDataText, MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
        }

        public static void ShowSlectRowsNotification()
        {
            //MessageBox.Show(Resources.ShowRowsCaption,
            //        Resources.ShowRowText, MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
        }

        public static void ShowInvalidValue()
        {
            //MessageBox.Show(Resources.InvalidInputCaption,
            //        Resources.InvalidIputText, MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
        }

        public static void ShowDuplicateData()
        {
            //MessageBox.Show(Resources.DuplicateDataCaption,
            //        Resources.DuplicateDataText, MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
        }
        #endregion

        // Notifications
        #region Notifications
        public static void ShowAddNotification()
        {
            //notifictionUser = new NotifictionUser(Resources.AddNotificationText);
            //notifictionUser.Show();
        }

        public static void ShowEditNotification()
        {
            //notifictionUser = new NotifictionUser(Resources.EditNotificationText);
            //notifictionUser.Show();
        }

        public static void ShowDeletNotification()
        {
            //notifictionUser = new NotifictionUser(Resources.DeleteNotificationText);
            //notifictionUser.Show();
        }
        #endregion

    }
}
