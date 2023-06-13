export default function NoPage() {

  document.title = 'Page Not Found (404)';
  return (
    <>
    <div className="container welcome-screen">
      <div className="row welcome-screen text">
        <label>
        <p>Page not found</p>
        </label>     
      </div>
    </div>
    </>
  );
}
  