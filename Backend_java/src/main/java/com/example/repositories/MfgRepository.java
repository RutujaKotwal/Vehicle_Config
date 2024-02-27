package com.example.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.entities.Mfg_master;
import com.example.entities.Segment_master;

import jakarta.transaction.Transactional;

@Repository
@Transactional
public interface MfgRepository extends JpaRepository<Mfg_master, Integer> {
	
	@Query(value = "select m.* from Mfg_master m join Segment_master s on s.Seg_id = m.Seg_id where m.Seg_id = :Seg_id",nativeQuery = true)
	List<Mfg_master>getManufacturers(@Param("Seg_id") int Seg_id);
	
}
