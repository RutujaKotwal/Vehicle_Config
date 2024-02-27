
package com.example.entities;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name = "alternate_component_master")
public class Alternate_component_master {
		@Id
		@GeneratedValue(strategy = GenerationType.IDENTITY)
		private int  Alt_id;
		private int mdl_id;
		private int Comp_id;
		private int Alt_Comp_id;
		private double Delta_Price;
		public int getAlt_id() {
			return Alt_id;
		}
		public void setAlt_id(int alt_id) {
			this.Alt_id = alt_id;
		}
		public int getModel_id() {
			return mdl_id;
		}
		public void setModel_id(int mdl_id) {
			this.mdl_id = mdl_id;
		}
		public int getComp_id() {
			return Comp_id;
		}
		public void setComp_id(int comp_id) {
			this.Comp_id = comp_id;
		}
		public int getAlt_comp_id() {
			return Alt_Comp_id;
		}
		public void setAlt_comp_id(int alt_comp_id) {
			this.Alt_Comp_id = alt_comp_id;
		}
		public double getDelta_price() {
			return Delta_Price;
		}
		public void setDelta_price(double delta_price) {
			this.Delta_Price = delta_price;
		}
		
		
		 
}