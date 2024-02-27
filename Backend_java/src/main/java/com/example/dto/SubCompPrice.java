package com.example.dto;

public class SubCompPrice {
	
	private String sub_type;
	
	private double Delta_Price;
	
	private int Alt_id;
	
	

	public SubCompPrice(String sub_type, double Delta_Price, int alt_id) {
		super();
		this.sub_type = sub_type;
		this.Delta_Price = Delta_Price;
		this.Alt_id = alt_id;
	}

	public String getSub_type() {
		return sub_type;
	}

	public void setSub_type(String sub_type) {
		this.sub_type = sub_type;
	}

	public double getPrice() {
		return Delta_Price;
	}

	public void setPrice(int price) {
		this.Delta_Price = price;
	}

	public int getAlt_id() {
		return Alt_id;
	}

	public void setAlt_id(int alt_id) {
		this.Alt_id = alt_id;
	}
	

}