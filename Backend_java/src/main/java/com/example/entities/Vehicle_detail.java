
package com.example.entities;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "Vehicle_detail")
public class Vehicle_detail {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int Confi_id;
	
	private String Comp_type;
	
	private String is_Configurable;
	
	@ManyToOne(cascade = CascadeType.ALL)
	@JoinColumn(name = "mdl_id")
	private Model_master Model_master;
	
	
	  @ManyToOne(cascade = CascadeType.ALL)
	  @JoinColumn(name = "Comp_id") 
	  private Component_master Component_master;
	 

	public int getConfig_id() {
		return Confi_id;
	}

	public void setConfig_id(int config_id) {
		this.Confi_id = config_id;
	}


	public String getComp_type() {
		return Comp_type;
	}

	public void setComp_type(String comp_type) {
		this.Comp_type = comp_type;
	}

	public String getIs_configurable() {
		return is_Configurable;
	}

	public void setIs_configurable(String is_Configurable) {
		this.is_Configurable = is_Configurable;
	}


}