package com.example.services;

import java.util.List;

import com.example.entities.Mfg_master;
import com.example.entities.Segment_master;

public interface MfgManager {
	List<Mfg_master> getallmanufacturer();
	List<Mfg_master> getManufacturerssegid(int Seg_id);
}