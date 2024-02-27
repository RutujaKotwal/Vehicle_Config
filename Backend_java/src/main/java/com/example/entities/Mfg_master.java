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
@Table(name = "mfg_master")
public class Mfg_master {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	int Mfg_id;
	String Mfg_name;

	@ManyToOne(cascade = CascadeType.ALL)
	@JoinColumn(name = "Seg_id")
	Segment_master segment_master;

	public int getMfg_id() {
		return Mfg_id;
	}

	public void setMfg_id(int mfg_id) {
		this.Mfg_id = mfg_id;
	}

	public String getMfg_name() {
		return Mfg_name;
	}

	public void setMfg_name(String mfg_name) {
		this.Mfg_name = mfg_name;
	}
}