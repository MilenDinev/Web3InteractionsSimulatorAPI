export function Card() {
  return (
    <>
      <div className="card">
        <p>Write here</p>
      </div>
      <svg className="filter">
        <filter id="wavy2">
          <feTurbulence
            x="0"
            y="0"
            baseFrequency="0.02"
            numOctaves="5"
            seed="1"
          ></feTurbulence>
          <feDisplacementMap in="SourceGraphic" scale="20"></feDisplacementMap>
        </filter>
      </svg>
    </>
  );
}
