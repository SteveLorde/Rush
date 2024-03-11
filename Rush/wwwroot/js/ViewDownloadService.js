import axios from "axios"
export async function DownloadItem(itemid) {
    var url = `/Index?handler=OnGetDownloadItem&itemid=${itemid}`;
    await axios.get(url)
}