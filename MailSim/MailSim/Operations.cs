﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace MailSim {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MailSimOperations {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventMonitor", typeof(MailSimOperationsEventMonitor))]
        [System.Xml.Serialization.XmlElementAttribute("FolderCreate", typeof(MailSimOperationsFolderCreate))]
        [System.Xml.Serialization.XmlElementAttribute("FolderDelete", typeof(MailSimOperationsFolderDelete))]
        [System.Xml.Serialization.XmlElementAttribute("MailMove", typeof(MailSimOperationsMailMove))]
        [System.Xml.Serialization.XmlElementAttribute("MailDelete", typeof(MailSimOperationsMailDelete))]
        [System.Xml.Serialization.XmlElementAttribute("MailForward", typeof(MailSimOperationsMailForward))]
        [System.Xml.Serialization.XmlElementAttribute("MailReply", typeof(MailSimOperationsMailReply))]
        [System.Xml.Serialization.XmlElementAttribute("MailSend", typeof(MailSimOperationsMailSend))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsEventMonitor {
        
        private string folderField;
        
        private string operationNameField;
       
        private string sleepField;
        
        /// <remarks/>
        public string Folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsFolderCreate {
        
        private string folderPathField;
        
        private string folderNameField;
        
        private string operationNameField;
        
        private string countField;
        
        private string sleepField;
        
        /// <remarks/>
        public string FolderPath {
            get {
                return this.folderPathField;
            }
            set {
                this.folderPathField = value;
            }
        }
        
        /// <remarks/>
        public string FolderName {
            get {
                return this.folderNameField;
            }
            set {
                this.folderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsFolderDelete {
        
        private string folderPathField;
        
        private string folderNameField;
        
        private string operationNameField;
        
        private string countField;
        
        private string sleepField;
        
        /// <remarks/>
        public string FolderPath {
            get {
                return this.folderPathField;
            }
            set {
                this.folderPathField = value;
            }
        }
        
        /// <remarks/>
        public string FolderName {
            get {
                return this.folderNameField;
            }
            set {
                this.folderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsMailMove {
        
        private string sourceFolderField;
        
        private string destinationFolderField;
        
        private string subjectField;
        
        private string operationNameField;
        
        private string countField;
        
        private string sleepField;
        
        /// <remarks/>
        public string SourceFolder {
            get {
                return this.sourceFolderField;
            }
            set {
                this.sourceFolderField = value;
            }
        }
        
        /// <remarks/>
        public string DestinationFolder {
            get {
                return this.destinationFolderField;
            }
            set {
                this.destinationFolderField = value;
            }
        }
        
        /// <remarks/>
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsMailDelete {
        
        private string folderField;
        
        private string subjectField;
        
        private string operationNameField;
        
        private string countField;
        
        private string sleepField;
        
        /// <remarks/>
        public string Folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsMailForward {
        
        private string folderField;
        
        private object[] itemsField;
        
        private RecipientTypes[] itemsElementNameField;
        
        private string mailSubjectToForwardField;
        
        private string forwardBodyField;
        
        private object[] items1Field;
        
        private string operationNameField;
        
        private string countField;
        
        private string sleepField;
        
        /// <remarks/>
        public string Folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RandomRecipients", typeof(MailSimOperationsRandomRecipients))]
        [System.Xml.Serialization.XmlElementAttribute("Recipients", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("RecipientType")]
        public object[] Recipients {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipientType")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public RecipientTypes[] RecipientType
        {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        public string MailSubjectToForward {
            get {
                return this.mailSubjectToForwardField;
            }
            set {
                this.mailSubjectToForwardField = value;
            }
        }
        
        /// <remarks/>
        public string ForwardBody {
            get {
                return this.forwardBodyField;
            }
            set {
                this.forwardBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("RandomAttachments", typeof(MailSimOperationsRandomAttachments))]
        public object[] Attachments {
            get {
                return this.items1Field;
            }
            set {
                this.items1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsRandomAttachments {
        
        private string countField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsMailReply {
        
        private string folderField;
        
        private string mailSubjectToReplyField;
        
        private string replyBodyField;
        
        private object[] itemsField;
        
        private string operationNameField;
        
        private bool replyAllField;
        
        private string countField;
        
        private string sleepField;
        
        /// <remarks/>
        public string Folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        public string MailSubjectToReply {
            get {
                return this.mailSubjectToReplyField;
            }
            set {
                this.mailSubjectToReplyField = value;
            }
        }
        
        /// <remarks/>
        public string ReplyBody {
            get {
                return this.replyBodyField;
            }
            set {
                this.replyBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("RandomAttachments", typeof(MailSimOperationsRandomAttachments))]
        public object[] Attachments {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReplyAll {
            get {
                return this.replyAllField;
            }
            set {
                this.replyAllField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsMailSend {
        
        private object[] itemsField;
        
        private RecipientTypes[] itemsElementNameField;
        
        private string subjectField;
        
        private string bodyField;
        
        private object[] items1Field;
        
        private string operationNameField;

        private string countField;
        
        private string sleepField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RandomRecipients", typeof(MailSimOperationsRandomRecipients))]
        [System.Xml.Serialization.XmlElementAttribute("Recipients", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("RecipientType")]
        public object[] Recipients {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipientType")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public RecipientTypes[] RecipientType {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        public string Body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("RandomAttachments", typeof(MailSimOperationsRandomAttachments))]
        public object[] Attachments {
            get {
                return this.items1Field;
            }
            set {
                this.items1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sleep {
            get {
                return this.sleepField;
            }
            set {
                this.sleepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum RecipientTypes {
        
        /// <remarks/>
        RandomRecipients,
        
        /// <remarks/>
        Recipients,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MailSimOperationsRandomRecipients {
        
        private string distributionListField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DistributionList {
            get {
                return this.distributionListField;
            }
            set {
                this.distributionListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="integer")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
