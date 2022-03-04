using System;
using System.Windows.Forms;
using System.Drawing;
using BioRails.Core.Api;
using BioRails.Core.Model;
using BR.Inv.Model;
using BR.Inv.Api;


namespace BR6WSInteractive
{

    public static class InvWSOutcome
    {
        //This class is designed to deal with the outcome of a web service call to the inventory module
        //Two methods exist. One for dealing with simple status objects and another for dealing with longer running jobs
//        public static void PostWSOutCome(BRInvReference.Status st, string operation, RichTextBox box)
//        {
//            try
//            {
//                Font normFont = new Font("Times New Roman", 10.0f);
//                //If all is well update a richtextbox with the good news
//                if (st.ok)
//                {
//                    RichTextBoxExtensions.AppendText(box, operation + " OK", Color.Green, normFont);
//                }
//                else
//                {
//                    //otherwise loop through the error messages and add those to the textbox
//                    RichTextBoxExtensions.AppendText(box, operation + " Failed", Color.Red, normFont);
//                    foreach (var er in st.messages)
//                    {
//                        RichTextBoxExtensions.AppendText(box, er.name + " " + er.value, Color.Red, normFont);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message, "Error");
//            }

//}

        public static void PostWSJobOutCome(string jobId, string operation, RichTextBox box, Session session, string url)
        {
            try
            {
                Font normFont = new Font("Times New Roman", 10.0f);
                BRJobWrapper jbAPI = new BRJobWrapper(session, url);
                //get the job object based on the job id
                BioRails.Core.Model.JobReport newjob = jbAPI.RefreshJob(jobId);
                do
                {
                    //wait a second
                    System.Threading.Thread.Sleep(1000);
                    //get the job again to check on its status
                    newjob = jbAPI.RefreshJob(jobId);
                    //if the job has completed with success or failure exit
                } while (newjob.Status != "finished" && newjob.Status != "error");

                //if there are log messages for the job
                if (newjob.Messages.Count > 0)
                {
                    foreach (string s in newjob.Messages)
                    {
                        //update the form with the messages
                        RichTextBoxExtensions.AppendText(box, operation + s, Color.Green, normFont);
                    }
                }
                //if there are error messages for the job
                if (newjob.ErrorMessage != null)
                {
                    //update the form with the messages
                    RichTextBoxExtensions.AppendText(box, operation + newjob.ErrorMessage, Color.Red, normFont);
                }
                else
                {
                    RichTextBoxExtensions.AppendText(box, operation + " Success", Color.Green, normFont);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
}
        //public static void PostWSJobOutCome(int jobid, string operation, RichTextBox box, BRCoreReference.Session session, InvWS invWS)
        //{
        //    try
        //    {
        //        Font normFont = new Font("Times New Roman", 10.0f);
        //        //get the job status based on the job i
        //        BRInvReference.ListStatus jobStatus = invWS.WSClient.material_upload_return(session.session_id, jobid);
        //        do
        //        {
        //            //wait a second
        //            System.Threading.Thread.Sleep(1000);
        //            //get the job again to check on its status
        //            jobStatus = invWS.WSClient.material_upload_return(session.session_id, jobid);
        //            //if the job has completed with success or failure exit
        //        } while (jobStatus.status != "finished" && jobStatus.status != "error");

        //        //if there are log messages for the job
        //        if (jobStatus.messages.Length > 0)
        //        {
        //            foreach (string s in jobStatus.messages)
        //            {
        //                //update the form with the messages
        //                RichTextBoxExtensions.AppendText(box, operation + s, Color.Green, normFont);
        //            }
        //        }
        //        else
        //        {
        //            RichTextBoxExtensions.AppendText(box, operation + "  Success", Color.Green, normFont);
        //        }
        //        //if there are error messages for the job

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error");
        //    }
        //}

    //    public static void PostBulkJobOutCome(int jobid, string operation, RichTextBox box, BRCoreReference.Session session, InvWS invWS)
    //    {
    //        try
    //        {
    //            Font normFont = new Font("Times New Roman", 10.0f);
    //            //get the job status based on the job i
    //            BRInvReference.ListStatus jobStatus = invWS.WSClient.material_upload_return(session.session_id, jobid);
    //            do
    //            {
    //                //wait a second
    //                System.Threading.Thread.Sleep(1000);
    //                //get the job again to check on its status
    //                jobStatus = invWS.WSClient.container_upload_return(session.session_id, jobid);
    //                //if the job has completed with success or failure exit
    //            } while (jobStatus.status != "finished" && jobStatus.status != "error");

    //            //if there are log messages for the job
    //            if (jobStatus.messages.Length > 0)
    //            {
    //                foreach (string s in jobStatus.messages)
    //                {
    //                    //update the form with the messages
    //                    RichTextBoxExtensions.AppendText(box, operation + s, Color.Green, normFont);
    //                }
    //            }
    //            else
    //            {
    //                RichTextBoxExtensions.AppendText(box, operation + "  Success", Color.Green, normFont);
    //            }
    //            //if there are error messages for the job
    //            if (jobStatus.list.Length > 0)
    //            {
    //                foreach (BRInvReference.Named nmd in jobStatus.list)
    //                {
    //                    RichTextBoxExtensions.AppendText(box, nmd.id.ToString() + " - " + nmd.name.ToString() , Color.Green, normFont);
    //                }
    //            }

    //        }   
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "Error");
    //        }
    //    }
    //
    }
}
