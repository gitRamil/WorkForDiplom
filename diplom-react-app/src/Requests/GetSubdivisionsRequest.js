const GetSubdivisionsRequest = async (component) =>
	await fetch('https://localhost:5001/api/Subdivision')
		.then(res => res.json());
		
export default GetSubdivisionsRequest;