
package com.example.entities;

import java.util.Set;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "Component_master")
public class Component_master {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int Comp_id;
	private String Comp_name;	
	private String sub_type;
	
	@OneToMany(cascade = CascadeType.ALL , mappedBy = "Component_master")
	private Set<Vehicle_detail> Vehicle_detail;

	public int getComp_id() {
		return Comp_id;
	}

	public void setComp_id(int comp_id) {
		this.Comp_id = comp_id;
	}

	public String getComp_name() {
		return Comp_name;
	}

	public void setComp_name(String comp_name) {
		this.Comp_name = comp_name;
	}
	public String getSub_type() {
		return sub_type;
	}

	public void setSub_type(String sub_type) {
		this.sub_type = sub_type;
	}

}
