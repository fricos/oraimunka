import React from 'react';
import '../App.css';
import './SectionTwo.css';

function SectionTwo() {
    return (
        <div className="sectionTwo">
            <h2>Témák és megkeresések amikkel nem foglalkozunk!</h2>
            <form className='form1'>
                    <div className="lilCard">
                    
                    <p><i class='bx bxs-info-square'></i> Politikai jellegű megkeresések</p>
                    </div>
                    <div className="lilCard">

                    <p><i class='bx bxs-info-square'></i> Bankok, hitelek, biztosítók</p>
                    </div>
                    <div className="lilCard">

                    <p><i class='bx bxs-info-square'></i> Mobil játékok, Pay to Win játékok</p>
                    </div>
                    <div className="lilCard">

                    <p><i class='bx bxs-info-square'></i> TV szereplés</p>
                    </div>
            </form>
        </div>
    )
}

export default SectionTwo;