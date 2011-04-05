

		public int ContractID {
			get { return (ViewState["ContractID"] == null ? -1 : (int)ViewState["ContractID"]); }
			set { ViewState["ContractID"] = value; }
		}

		public string ContractRef {
			get { return (ViewState["ContractRef"] == null ? string.Empty : (string)ViewState["ContractRef"]); }
			set { ViewState["ContractRef"] = value; }
		}
