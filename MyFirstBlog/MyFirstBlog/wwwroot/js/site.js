// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// <Posts>

const loadPosts = filter => getPosts(filter).then(renderPosts);

const getPosts = title => axios
    .get('/api/post', title ? { params: { title } } : {})
    .then(res => res.data);

const renderPosts = posts => {
    const noPosts = document.querySelector("#no-posts");
    const loader = document.querySelector("#posts-loader");
    const postsTbody = document.querySelector("#posts");
    const postsTable = document.querySelector("#posts-table");
    const postFilter = document.querySelector("#posts-filter");

    if (posts && posts.length > 0) {
        postsTable.classList.add("show");
        postFilter.classList.add("show");
        noPosts.classList.remove("show");
    }
    else noPosts.classList.add("show");

    loader.classList.add("hide");

    postsTbody.innerHTML = posts.map(postComponent).join('');
};

const postComponent = post => `
    <tr>
        <td>${post.id}</td>
        <td class="image"><img class="post-link-image" src="${post.imgSrc}"></td>
        <td class="title">
            <a href="/post/detail/${post.id}">${post.title}</a>
        </td>
        <td class="description">${post.description}</td>
        <td>${post.category.title}</td>
        <td class="grid gap">
            <a href="/post/apiedit/${post.id}">Edit</a>
        </td>
    </tr>`;

const initFilter = () => {
    const filter = document.querySelector("#posts-filter input");
    filter.addEventListener("input", (e) => loadPosts(e.target.value))
};

// </Posts>

// <Categories>

const loadCategories = () => getCategories().then(renderCategories);

const getCategories = () => axios
    .get("/api/category")
    .then(res => res.data);

const renderCategories = categories => {
    const selectCategory = document.querySelector("#category-id");
    selectCategory.innerHTML += categories.map(categoryOptionComponent).join('');
};

const categoryOptionComponent = category => `<option value=${category.id}>${category.title}</option>`;

// </Categories>

// <Tags>

const loadTags = () => getTags().then(renderTags);

const getTags = () => axios
    .get("/api/tag")
    .then(res => res.data);

const renderTags = tags => {
    const tagsSelection = document.querySelector("#tags");
    tagsSelection.innerHTML = tags.map(tagOptionComponent).join('');
}

const tagOptionComponent = tag => `
	<div class="flex gap">
		<input id="${tag.id}" type="checkbox" />
		<label for="${tag.id}">${tag.title}</label>
	</div>`;

// </Tags>

// <CreatePost>

const postPost = post => axios
    .post("/api/post", post)
    .then(() => location.href = "/post/apiindex")
    .catch(err => renderErrors(err.response.data.errors));

const initCreateForm = () => {
    const form = document.querySelector("#post-create-form");

    form.addEventListener("submit", e => {
        e.preventDefault();

        const post = getPostFromForm(form);
        postPost(post);
    });
};

const getPostFromForm = form => {
    const title = form.querySelector("#title").value;
    const description = form.querySelector("#description").value;
    const imageUrl = form.querySelector("#image-url").value;
    //const imageFile = form.querySelector("#image-file");
    const categoryId = form.querySelector("#category-id").value;
    //const tags = form.querySelectorAll("#tags input");

    return {
        id: 0,
        title,
        description,
        imageUrl,
        //imageFile,
        categoryId,
        //tags
    };
};

const renderErrors = errors => {
    const titleErrors = document.querySelector("#title-errors");
    const descriptionErrors = document.querySelector("#description-errors");
    const categoryIdErrors = document.querySelector("#category-id-errors");

    titleErrors.innerText = errors.Title?.join("\n") ?? "";
    descriptionErrors.innerText = errors.Description?.join("\n") ?? "";
    categoryIdErrors.innerText = errors.CategoryId?.join("\n") ?? "";
};

// </CreatePost>

// <EditPost>

const initEditForm = () => {
    const form = document.querySelector("#post-edit-form");
    const title = form.querySelector("#title");
    const description = form.querySelector("#description");
    const imageUrl = form.querySelector("#image-url");
    const categoryId = form.querySelector("#category-id");

    const post = getPost().then(post => {

    });
};

const getPost = id => axios
    .get(`/api/post/${id}`)
    .then(res => res.data);

// </EditPost>