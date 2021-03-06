﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInserter.Db {
	public class ConnectionString {

		private static ConnectionString instance = null;

		public string Host { get; set; }
		public string Port { get; set; }
		public string Database { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

		public string String {
			get {
				if (!string.IsNullOrEmpty(this.Password)) {
					//return "server=" + this.Host + ";port=" + this.Port + ";uid=" + this.Username + ";pwd=" + this.Password + ";database=" + this.Database;
					return "server=" + this.Host + ";uid=" + this.Username + ";pwd=" + this.Password + ";database=" + this.Database;
				} else {
					//return "server=" + this.Host + ";port=" + this.Port + ";uid=" + this.Username + ";database=" + this.Database;
					return "server=" + this.Host + ";uid=" + this.Username + ";database=" + this.Database;
				}
			}
		}


		private ConnectionString() {
			this.Host = string.Empty;
			this.Port = string.Empty;
			this.Database = string.Empty;
			this.Username = string.Empty;
			this.Password = string.Empty;
		}

		public static ConnectionString Instance {
			get {
				if(instance == null) {
					instance = new ConnectionString();
				}
				return instance;
			}
		}

	}
}
