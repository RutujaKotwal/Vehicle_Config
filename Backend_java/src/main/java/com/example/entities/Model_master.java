
package com.example.entities;

import java.util.Set;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;
import com.example.entities.Segment_master;

@Entity
@Table(name = "Model_master")
public class Model_master {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	int mdl_id;
	String Mdl_name;
	double price;
	


	@ManyToOne(cascade = CascadeType.ALL)
	@JoinColumn(name = "Seg_id")
	Segment_master segment_master;

	@ManyToOne(cascade = CascadeType.ALL)
	@JoinColumn(name = "Mfg_id")
	Mfg_master Mfg_master;
	
	
	  @OneToMany(cascade = CascadeType.ALL , mappedBy = "Model_master") private
	  Set<Vehicle_detail> Vehicle_detail;
	 
	  String Image_path;
	  

	public String getImage_path() {
		return Image_path;
	}

	public void setImage_path(String image_path) {
		Image_path = image_path;
	}

	public int getModel_id() {
		return mdl_id;
	}

	public void setModel_id(int mdl_id) {
		this.mdl_id = mdl_id;
	}

	public String getModel_name() {
		return Mdl_name;
	}

	public void setModel_name(String model_name) {
		this.Mdl_name = model_name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}
	
}
