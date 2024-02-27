package com.example.services;

import java.util.List;

import com.example.entities.Model_master;

public interface ModelManager {
	List<Model_master> getvariant(int Seg_id , int Mfg_id);

	
}