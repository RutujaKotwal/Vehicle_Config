
package com.example.entities;

import java.util.Set;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "Segment_master")
public class Segment_master {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	int Seg_id;
	String Seg_name;
	@OneToMany(mappedBy = "segment_master", cascade = CascadeType.ALL)
	Set<Mfg_master> mfg_master;

	
	  @OneToMany(mappedBy = "segment_master", cascade = CascadeType.ALL) 
	  Set<Model_master> model_master;
	 


	public int getSeg_id() {
		return Seg_id;
	}

	public void setSeg_id(int seg_id) {
		this.Seg_id = seg_id;
	}

	public String getSeg_name() {
		return Seg_name;
	}

	public void setSeg_name(String seg_name) {
		this.Seg_name = seg_name;
	}



}